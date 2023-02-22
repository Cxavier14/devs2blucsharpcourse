import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  URL_API:string = 'https://pokeapi.co/api/v2';
  constructor() { }
}
