import { Component, OnInit } from '@angular/core';
import { ValuesService } from 'src/app/services/values.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-values',
  templateUrl: './values.component.html',
  styleUrls: ['./values.component.css']
})
export class ValuesComponent implements OnInit {

  fruits$: Observable<any[]>;

  constructor(private valuesService: ValuesService) { }

  ngOnInit() {
    this.fruits$ = this.valuesService.getAllValues();
  }

}
