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

    ngAfterViewInit(): void {

    }

    receiveMaterial(): void {
        
    }

    // Show Modals
    processBatchReceiving(): void {
        this.processBatchModal.show();
    }

    //editBatchReceiving(batch: BatchDto): void {
    //    this.editBatchReceivingModal.show(batch.id);
    //}
}
