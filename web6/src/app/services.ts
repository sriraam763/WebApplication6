import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { todo } from './todolist';

@Injectable({
  providedIn: 'root',
})
export class Services {
  private http=inject(HttpClient);
  private apiurl="http://localhost:5218/api/Tasklist";

  gettask():Observable<todo[]>{
    return this.http.get<todo[]>(this.apiurl);
  }

  addtask(task:todo):Observable<any>{
    return this.http.post(this.apiurl,task);
  }
}
