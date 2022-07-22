import { NgModule } from '@angular/core';
import { APP_BASE_HREF, CommonModule } from '@angular/common';
import { HelloWorldComponent } from './hello-world.component';
import { BrowserModule } from '@angular/platform-browser';
import { ComponentOneComponent } from './component-one/component-one.component';
import { ComponentTwoComponent } from './component-two/component-two.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: 'one', component: ComponentOneComponent },
  { path: 'two', component: ComponentTwoComponent },
  { path: '', redirectTo: 'one', pathMatch: 'full'}
];

@NgModule({
  declarations: [
    HelloWorldComponent,
    ComponentOneComponent,
    ComponentTwoComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    RouterModule.forRoot(routes)
  ],
  exports: [HelloWorldComponent, ComponentOneComponent, ComponentTwoComponent],
  providers:[{provide: APP_BASE_HREF, useValue : '' }],
  bootstrap:[HelloWorldComponent]
})
export class HelloWorldModule { }
