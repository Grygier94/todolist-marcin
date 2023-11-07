import { Component, OnInit } from '@angular/core';
import { Observable, map } from 'rxjs';
import { TaskModel } from 'src/app/models/task';
import { TasksService } from 'src/app/services/tasks.service';

@Component({
  selector: 'app-completed-tasks',
  templateUrl: './completed-tasks.component.html',
  styleUrls: ['./completed-tasks.component.scss']
})
export class CompletedTasksComponent implements OnInit {

  public tasks$!: Observable<TaskModel[]>;

  constructor(private taskService: TasksService) { }

  ngOnInit(): void {
    this.tasks$ = this.taskService.tasks.pipe(map(tasks => tasks.filter(task => task.isCompleted)));
  }

}
