import { TasksService } from 'src/app/services/tasks.service';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { TaskModel } from 'src/app/models/task';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.scss']
})
export class TaskListComponent implements OnInit {

  public tasks$!: Observable<TaskModel[]>;

  constructor(private taskService: TasksService) { }

  public ngOnInit(): void {
    this.tasks$ = this.taskService.tasks;
  }
}
