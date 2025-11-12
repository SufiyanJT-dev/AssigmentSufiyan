import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root',
})
export class Apicommuncation {
  constructor(private http: HttpClient){}
  private api="https://localhost:7119/api/"
  
 Validation(loginDetails: any): Observable<any> {
    return this.http.post(this.api + 'Employee/validate-login', loginDetails);
  }
filtering(FilterQuery: any): Observable<any> {
 const params=new HttpParams({fromObject:FilterQuery})
  return this.http.get(this.api + 'Hotel/filter', {params:params});


  }

  }

