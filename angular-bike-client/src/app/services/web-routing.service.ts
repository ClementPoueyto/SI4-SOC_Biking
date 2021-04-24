import { RootObject, Itinerary } from '../../models/itinerary.models';
import { Position } from '../../models/position.models';
import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { BehaviorSubject } from 'rxjs/internal/BehaviorSubject';
import { httpOptionsBase, serverUrl } from 'src/config/server.config';

@Injectable({
  providedIn: 'root'
})
export class WebRoutingService {

  public itineraries : Itinerary[]=[];
  private URL: string = serverUrl + 'path';
  public itineraries$: BehaviorSubject<Itinerary[]> = new BehaviorSubject(this.itineraries);
  private httpOptions = httpOptionsBase;
  constructor(private http: HttpClient) { }


  getPath(start : string  ="paris", end : string = "paris") {
    return this.http.get<Itinerary[]>(this.URL + "?start="+start+"&end="+end, this.httpOptions)
  }
}
