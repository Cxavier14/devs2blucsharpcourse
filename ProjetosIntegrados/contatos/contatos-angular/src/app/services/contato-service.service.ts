import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Contato } from '../model/contatos';

@Injectable({
  providedIn: 'root'
})
export class ContatoServiceService {

  URL_API : string = "https://localhost:7160/Contatos/GetContatos"

  constructor(public http: HttpClient) { }

  buscaContatos() {
    return this.http.get<Contato>(this.URL_API);
  }

  addContato(contato: Contato) {
    return this.http.post<Contato>(this.URL_API, contato);
  }
}
