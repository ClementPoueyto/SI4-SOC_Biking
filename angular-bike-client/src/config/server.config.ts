import {HttpHeaders} from '@angular/common/http';

export const httpOptionsBase = {
  headers: new HttpHeaders({
    'content-type': 'application/json',
    'Accept' : '*/*'
    })
};

export const serverUrl = 'http://localhost:4200/api/Web/';
export const serverUrlDev = 'http://localhost:4200/api/Design_Time_Addresses/WebRoutingService/Service1/';
