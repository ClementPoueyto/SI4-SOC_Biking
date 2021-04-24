

  export interface Geometry {
      coordinates: number[][];
      type: string;
  }

  export interface Step {
      distance: number;
      duration: number;
      instruction: string;
      name: string;
      type: number;
  }

  export interface Segment {
      distance: number;
      duration: number;
      steps: Step[];
  }

  export interface Properties {
      segments: Segment[];
  }

  export interface Feature {
      bbox: number[];
      geometry: Geometry;
      properties: Properties;
  }

  export interface Itinerary {
      bbox: number[];
      features: Feature[];
  }

  export interface RootObject {
      GetItineraryResult: Itinerary[];
  }



