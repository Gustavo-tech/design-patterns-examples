using Mediator;

// Instantiate the Mediator (Airport Control Tower)
IAirTrafficControlTower controlTower = new AirportControlTower();

// Instantiate Concrete Colleagues (Commercial Airplanes)
IAirplane airplane1 = new CommercialAirplane(controlTower);
IAirplane airplane2 = new CommercialAirplane(controlTower);

// Set up the association between Concrete Colleagues and the Mediator
airplane1.RequestTakeOff();
airplane2.RequestLanding();