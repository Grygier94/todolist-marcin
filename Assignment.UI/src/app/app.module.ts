import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NewTaskFormComponent } from './components/tasks/new-task-form/new-task-form.component';
import { TaskListComponent } from './components/tasks/task-list/task-list.component';
import { CompletedTasksComponent } from './components/tasks/completed-tasks/completed-tasks.component';
import { TasksPageComponent } from './components/tasks/tasks-page/tasks-page.component';
import { TasksApiService } from './services/tasks-api.service';
import { TasksService } from './services/tasks.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    NewTaskFormComponent,
    TaskListComponent,
    CompletedTasksComponent,
    TasksPageComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
  ],
  providers: [
    TasksService,
    TasksApiService,
    {
      provide: "BASE_API_URL", useValue: "http://localhost:7118"
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
