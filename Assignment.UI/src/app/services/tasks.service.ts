import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { TasksApiService } from './tasks-api.service';
import { TaskModel } from '../models/task';

@Injectable({
  providedIn: 'root'
})
export class TasksService {

  public tasks: BehaviorSubject<TaskModel[]> = new BehaviorSubject<TaskModel[]>([]);

  constructor(
    private tasksService: TasksApiService
  ) {
    this.tasksService.getTasks().subscribe(tasks =>
      this.tasks.next(tasks)
    );
  }
}
