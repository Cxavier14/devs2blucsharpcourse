import { Component, OnInit } from '@angular/core';
import { Pokemon } from 'src/app/models/api/pokemon-model';
import { ApiService } from 'src/app/service/api.service';

@Component({
  selector: 'app-random',
  templateUrl: './random.component.html',
  styleUrls: ['./random.component.scss']
})
export class RandomComponent implements OnInit {

  public pokemon = new Pokemon({});

  constructor(public service: ApiService) { }

  ngOnInit(): void {
    this.service.getRandomPokemon().subscribe(
      (resp) => {
        this.pokemon = resp;
    })
  }
}
