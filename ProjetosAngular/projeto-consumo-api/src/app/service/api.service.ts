import { ApiReturn } from './../models/api-return';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Pokemon } from '../models/api/pokemon-model';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  URL_API:string = 'https://pokeapi.co/api/v2/pokemon';

  constructor(public http:HttpClient) { }

  getPokemonList(){
    return this.http.get<ApiReturn>(this.URL_API);
  }

  getPokemonByName(name: string) {
    return this.http.get<Pokemon>(`${this.URL_API}/${name}`);
  }

  getRandomPokemon() {
    const array: number[] = Array(1).fill(1).map(() => Math.floor(1000 * Math.random()));
    return this.http.get<Pokemon>(`${this.URL_API}/${array}`);
  }
}
