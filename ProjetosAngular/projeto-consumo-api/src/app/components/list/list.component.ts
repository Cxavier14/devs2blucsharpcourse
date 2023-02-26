import { ApiReturn, Results } from './../../models/api-return';
import { ApiService } from './../../service/api.service';
import { Component, OnInit } from '@angular/core';
import { Observable, Subject } from 'rxjs';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  public resultList$ = new Subject<Results[] | undefined>();

  constructor(public service: ApiService) {}

  ngOnInit(): void {
    this.service.getPokemonList().subscribe(
      (resp) => {
        console.log(resp);
        this.resultList$.next(resp.results);
      }
    )
  }
}
