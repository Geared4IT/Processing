import { Component, ViewChild, Injector, Output, EventEmitter, ElementRef, OnInit } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap';
import { UserServiceProxy, CreateUserDto, RoleDto } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';
import { finalize } from 'rxjs/operators';

@Component({
    selector: 'process-batch-modal',
    templateUrl: './process-batch.component.html'
}) 
export class ProcessBatchComponent extends AppComponentBase implements OnInit {

    @ViewChild('processBatchModal') modal: ModalDirective;
    @ViewChild('modalContent') modalContent: ElementRef;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active: boolean = false;
    saving: boolean = false;

    today = null;
   
    constructor(
        injector: Injector
    ) {
        super(injector);
       
    }

    ngOnInit(): void {
        this.today = new Date();
    }

    show(): void {
        this.active = true;
        this.modal.show();
        //this.user = new CreateUserDto();
        //this.user.init({ isActive: true });
    }

    onShown(): void {
        $.AdminBSB.input.activate($(this.modalContent.nativeElement));
    }

    save(): void {
        close();
    }

    close(): void {
        this.active = false;
        this.modal.hide();
    }
}