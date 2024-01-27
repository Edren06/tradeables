import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private apiUrl = 'http://localhost:5068'; // Replace with your API URL

  constructor(private http: HttpClient) { }

  getData(path: string, queryParams?: any): Observable<any> {
    const url = `${this.apiUrl}/api/${path}`;
    const options = {
      params: queryParams
    };

    return this.http.get<any>(url, options);
  }

  postData(path: string, body: any): Observable<any> {
    const url = `${this.apiUrl}/api/${path}`;
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });

    console.log("Test");
    return this.http.post<any>(url, body, { headers });
  }

  putData(path: string, body: any): Observable<any> {
    const url = `${this.apiUrl}/api/${path}`;
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });

    console.log("Test");
    return this.http.put<any>(url, body, { headers });
  }
}