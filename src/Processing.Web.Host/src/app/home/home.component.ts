import { Component, Injector, AfterViewInit, ViewChild } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { ProcessBatchComponent } from 'app/home/process-batch/process-batch.component';

@Component({
    templateUrl: './home.component.html',
    animations: [appModuleAnimation()]
})
export class HomeComponent extends AppComponentBase implements AfterViewInit {
    @ViewChild('processBatchModal') processBatchModal: ProcessBatchComponent;

    constructor(
        injector: Injector
    ) {
        super(injector);
    }

    mockUpStatus = -1;

    ngAfterViewInit(): void {

    }

    receiveMaterial(): void {
        
    }

    // Show Modals
    processBatchReceiving(): void {
        this.processBatchModal.show();
        this.mockUpStatus = 0;
    }

    backToDashboard(): void {
        this.mockUpStatus = 0
            ;
    }

    showLotProcessingDetails(): void {
        this.mockUpStatus = 3;
    }

    refresh(): void {}

}
