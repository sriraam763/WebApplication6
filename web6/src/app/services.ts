import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { todo } from './todolist';

@Injectable({
  providedIn: 'root',
})
export class Services {
  private http=inject(HttpClient);
  private apiurl="https://webappazure6-amgkc6egdzh3e0a8.centralindia-01.azurewebsites.net";

  gettask():Observable<todo[]>{
    return this.http.get<todo[]>(this.apiurl);
  }

  addtask(task:todo):Observable<any>{
    return this.http.post(this.apiurl,task);
  }
}
