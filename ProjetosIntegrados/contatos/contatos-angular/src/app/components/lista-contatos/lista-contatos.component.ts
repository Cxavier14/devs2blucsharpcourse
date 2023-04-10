import { Component, OnInit } from '@angular/core';
import { Subject } from 'rxjs';
import { Contato } from 'src/app/model/contatos';
import { ContatoServiceService } from 'src/app/services/contato-service.service';

@Component({
  selector: 'app-lista-contatos',
  templateUrl: './lista-contatos.component.html',
  styleUrls: ['./lista-contatos.component.scss']
})
export class ListaContatosComponent implements OnInit {

// public listaResultados = new Subject<Contatos[] | undefined>();
public lista$: any = [];

constructor(public service: ContatoServiceService){}

ngOnInit(): void {
  this.service.buscaContatos().subscribe(
    (resposta) => {
      this.lista$ = resposta;
    }
  )
}

}
