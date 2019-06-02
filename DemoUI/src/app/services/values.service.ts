import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ValuesService {

  constructor(private httpClient: HttpClient) { }

  getAllValues(): Observable<any[]> {
    return this.httpClient.get<any[]>('http://localhost:5000/api/fruits');
  }
}
