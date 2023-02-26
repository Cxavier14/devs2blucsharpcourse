import { ApiService } from './../../service/api.service';
import { Component, OnInit } from '@angular/core';
import { Subject } from 'rxjs';
import { Results } from 'src/app/models/api-return';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit{

  public resultList$ = new Subject<Results[] | undefined>();

  constructor(public service: ApiService){}

  ngOnInit(): void {
    this.service.getCharacterList().subscribe(
      (resp) => {
        console.log(resp);
        this.resultList$.next(resp.results);
      }
    )
  }
}
