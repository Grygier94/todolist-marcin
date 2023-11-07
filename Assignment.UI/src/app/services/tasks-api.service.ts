import { Inject, Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { TaskModel } from '../models/task';

@Injectable({
  providedIn: 'root'
})
export class TasksApiService {

  constructor(
    private httpClient: HttpClient,
    @Inject('BASE_API_URL') private baseUrl: string
  ) { }

  public getTasks(): Observable<TaskModel[]> {
    return this.httpClient.get<TaskModel[]>(`${this.baseUrl}/Tasks`);
  }

  public addTasks(task: TaskModel): void {
    this.httpClient.post(`${this.baseUrl}/Tasks`, task);
  }

  public updateTask(task: TaskModel): void {
    this.httpClient.put(`${this.baseUrl}/Tasks`, task);
  }

  public deleteTask(taskId: number): void {
    this.httpClient.delete(`${this.baseUrl}/Tasks/${taskId}`);
  }
}
