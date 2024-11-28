﻿using AbstractFactory.Factory;

IGUIFactory factory;

factory = new WindowsFactory();
factory.CreateButton().Paint();
factory.CreateCheckbox().Paint();

factory = new MacFactory();
factory.CreateButton().Paint();
factory.CreateCheckbox().Paint();