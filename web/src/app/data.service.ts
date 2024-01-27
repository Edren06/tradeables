import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private apiUrl = 'http://localhost:5068'; // Replace with your API URL

  constructor(private http: HttpClient) { }

  getData(path:string): Observable<any> {
    console.log("Test");
    return this.http.get<any>(`${this.apiUrl}/api/${path}`);
  }
}