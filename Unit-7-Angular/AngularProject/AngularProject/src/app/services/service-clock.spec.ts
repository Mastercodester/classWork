import { TestBed } from '@angular/core/testing';

import { ServiceClock } from './service-clock';

describe('ServiceClock', () => {
  let service: ServiceClock;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServiceClock);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
