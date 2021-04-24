import { Itinerary } from './../models/itinerary.models';
import { WebRoutingService } from './services/web-routing.service';
import { AfterViewChecked, AfterViewInit, Component } from '@angular/core';
import { defaults as defaultControls } from 'ol/control';

import * as olProj from 'ol/proj';
import * as geom from 'ol/geom';

import Source from 'ol/source';
import XYZ from 'ol/source/XYZ';
import ZoomToExtent from 'ol/control/ZoomToExtent';
import Map from 'ol/Map';
import VectorSource from 'ol/source/Vector';
import VectorLayer from 'ol/layer/Vector';
import View from 'ol/View';
import Feature from 'ol/Feature';
import Point from 'ol/geom/Point';
import lineString from 'ol/geom/LineString';
import * as Style from 'ol/style';

import XyzSource from 'ol/source/XYZ';
import TileLayer from 'ol/layer/Tile';

import { fromLonLat } from 'ol/proj';
import { OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css',  "./../../node_modules/ol/ol.css",
]
})

export class AppComponent implements OnInit, AfterViewChecked {


  lng : number = 2.333333;
  lat : number = 48.866667
  start;
  end;

  map: Map;
  itineraries : Itinerary[]
  coordinates1 : number[][]=[]
  coordinates2 : number[][]=[]
  coordinates3 : number[][]=[]
  toDelete : Feature[];
  constructor(private service : WebRoutingService){
  }
  ngAfterViewChecked(): void {

  }
    vectorSource: VectorSource;
    vectorLayer: VectorLayer;
    xyzSource: XyzSource;
    tileLayer: TileLayer;
    view: View;
    markers: Feature=[];
    indexes: number[];
    ngOnInit() {

      /*// Feature and vector
      this.markers.push( new Feature({
        geometry: new Point(fromLonLat([this.lng, this.lat]))
      }));


      this.vectorSource = new VectorSource({
        features: this.markers
      });*/

      this.vectorLayer = new VectorLayer({
        source: this.vectorSource
      });

      // XYZ
      this.xyzSource = new XyzSource({
        url: 'http://tile.osm.org/{z}/{x}/{y}.png'
      });

      this.tileLayer = new TileLayer({
        source: this.xyzSource
      });

      // View and map
      this.view = new View({
        center: fromLonLat([this.lng, this.lat]),
        zoom: 14
      });

      this.map = new Map({
        target: 'map',
        layers: [this.tileLayer, this.vectorLayer],
        view: this.view
      });
    }

  onStart(value: string) {
    this.start=value
  }

  onEnd(value: string) {
    this.end=value
  }


  addMarkers(pos : number[][], colors: string){
    let marks =[];
    for(let i =0;i< pos.length-1; i++){
      let point = new Feature({
        geometry: new lineString([fromLonLat([pos[i][0], pos[i][1]]),fromLonLat([pos[i+1][0], pos[i+1][1]])])

      })
      marks.push(point);

  }

  var lineStyle = new Style.Style({
    stroke: new Style.Stroke({
        color: colors,
        width: 10
    })
  });

  this.vectorSource = new VectorSource({
    features: marks
  });
  this.vectorLayer = new VectorLayer({
    source: this.vectorSource,
    style: [lineStyle]

  });
  this.view = new View({
    center: fromLonLat(this.coordinates1[0]),
    zoom: 14
  });
  this.map.setView(this.view)
  this.map.addLayer(this.vectorLayer);
  }

  search(){
    this.service.getPath(this.start, this.end).subscribe((res) => {
      console.log(res)
      if(res!=null&&res.length>0){
        console.log("je rnetre")
        this.coordinates1=[];
        this.coordinates2=[];
        this.coordinates3=[];


        this.itineraries = res
        this.initCoordinates(this.itineraries[0],1)
        this.initCoordinates(this.itineraries[1],2)
        this.initCoordinates(this.itineraries[2],3)

        this.addMarkers(this.coordinates1, "#0000CD"	);
        this.addMarkers(this.coordinates2, "#FF0000"	);
        this.addMarkers(this.coordinates3, "#0000CD");

      }
    });

  }

  initCoordinates(itins:Itinerary, index  :number){
      for(let j = 0; j< itins.features.length; j++){
        for(let n = 0; n< itins.features[j].geometry.coordinates.length; n++){
          switch(index){
            case 1:
              this.coordinates1.push(itins.features[j].geometry.coordinates[n]);
            break;
            case 2:
              this.coordinates2.push(itins.features[j].geometry.coordinates[n]);
            break;
            case 3:
              this.coordinates3.push(itins.features[j].geometry.coordinates[n]);
            break;
          }

      }
    }
  }


  /*setView(){
    var view = this.map.getView();
      view.setCenter(ol.proj.fromLonLat([this.latitude, this.longitude]));
      //view.addMarker(ol.proj.fromLonLat([this.latitude, this.longitude]));
      view.setZoom(8);

      var source = new ol.source.vector({});
      var layer = new ol.layer.vector({ source: source});
      this.map.addLayer(layer );
      var marker = new ol.Feature({
        geometry: new ol.geom.Point([this.latitude,this.longitude]) // dont worry about coordinate type 0,0 will be in west coast of africa
    });
    source.addFeature(marker);
  }*/
}
