import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { AdminFormComponent } from './admin-form/admin-form.component';
import { AdminListComponent } from './admin-list/admin-list.component';

// These are the routes
const appRoutes: Routes = [
  {path: '', redirectTo: 'value', pathMatch: 'full' },
  { path: 'value',  component: AdminListComponent },
  { path: '**', redirectTo: ''}
];

@NgModule({
  declarations: [
    AppComponent,
    AdminFormComponent,
    AdminListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
