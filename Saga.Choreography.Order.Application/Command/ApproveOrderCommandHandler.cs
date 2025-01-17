﻿using MediatR;
using Saga.Choreography.Core.Domain;
using Saga.Choreography.Core.Domain.Bus;
using Saga.Choreography.Core.Domain.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saga.Choreography.Order.Application.Command
{
    public class ApproveOrderCommandHandler : IRequestHandler<ApproveOrderCommand, Guid>
    {
        private readonly IEventBusService<IEventBus> _eventBusService;
        public ApproveOrderCommandHandler(IEventBusService<IEventBus> eventBusService)
        {
            _eventBusService = eventBusService;
        }
        public async Task<Guid> Handle(ApproveOrderCommand request, CancellationToken cancellationToken)
        {
           //..
           //Update order state as completed.
           //..

            return Guid.NewGuid();
        }
    }
}
