import { TestBed } from '@angular/core/testing';

import { WebRoutingService } from './web-routing.service';

describe('WebRoutingService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: WebRoutingService = TestBed.get(WebRoutingService);
    expect(service).toBeTruthy();
  });
});
