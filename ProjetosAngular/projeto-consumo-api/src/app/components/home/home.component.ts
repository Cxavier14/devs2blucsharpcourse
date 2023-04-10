import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/service/api.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  constructor(public service: ApiService) { }

  ngOnInit(): void {
    this.getRandom();
  }

  public getRandom(){
    this.service.getRandomPokemon();
  }
}
