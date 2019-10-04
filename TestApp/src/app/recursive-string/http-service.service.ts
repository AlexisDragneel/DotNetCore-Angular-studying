import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpServiceService {

  constructor(private http: HttpClient) { }

  enpointUrl = "https://localhost:44353/api/test/chairString"

  getRecursiveSubStrign(input: string): Observable<string[]>{
    let params = new HttpParams().set("input", input);
    return this.http.get<string[]>(this.enpointUrl, {
      params: params
    })
  }

}
