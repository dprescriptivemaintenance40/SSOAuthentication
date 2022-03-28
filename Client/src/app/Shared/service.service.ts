import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Login } from './_Login';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {

  constructor(private http:HttpClient) { }
  Login(loginRequest:Login):Observable<any>{
    return this.http.post("https://localhost:44353/api/PlantAuthentication/login",loginRequest);
  }

}
