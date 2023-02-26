import { ApiReturn } from './../models/api-return';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  URL_API : string = 'https://rickandmortyapi.com/api/character';

  constructor(public http: HttpClient) { }

  getCharacterList(){
    return this.http.get<ApiReturn>(this.URL_API);
  }
}
