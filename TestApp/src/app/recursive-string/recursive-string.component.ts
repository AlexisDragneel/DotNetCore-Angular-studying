import { Component, OnInit } from '@angular/core';
import { HttpServiceService } from './http-service.service'

@Component({
  selector: 'app-recursive-string',
  templateUrl: './recursive-string.component.html',
  styleUrls: ['./recursive-string.component.css']
})
export class RecursiveStringComponent implements OnInit {

  response = null
  data = "Hello";
  constructor( private httpService: HttpServiceService ) { }

  ngOnInit() {
  }

  getRecursiveString(){
    this.httpService
    .getRecursiveSubStrign(this.data)
    .subscribe(strings => this.response = strings);
    console.log(this.response)
  }

}
