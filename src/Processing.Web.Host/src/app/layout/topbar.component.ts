import { Component, Injector, ViewEncapsulation, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
    templateUrl: './topbar.component.html',
    selector: 'top-bar',
    encapsulation: ViewEncapsulation.None
})
export class TopBarComponent extends AppComponentBase implements OnInit {
  //  myDate: Date;
    constructor(
        injector: Injector
    ) {
        super(injector);
    }

    ngOnInit() {
        //this.myDate = setInterval(() => {
        //    this.myDate = new Date();
        //}, 1000);
    }
}