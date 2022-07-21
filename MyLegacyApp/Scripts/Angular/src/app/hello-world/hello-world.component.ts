import { Component, ElementRef } from '@angular/core';

@Component({
  selector: 'app-hello-world',
  templateUrl: './hello-world.component.html',
  styleUrls: ['./hello-world.component.scss']
})
export class HelloWorldComponent {

  constructor(private elementRef: ElementRef) {
    var current_user = this.elementRef.nativeElement.getAttribute('current-user') ?? null;
    console.log('current-user', current_user);
  }
}
