-- Insertando datos iniciales en la tabla Countries
INSERT INTO Countries (country) VALUES 
('Germany'),
('Australia'),
('India'),
('Japan'),
('South Korea'),
('France'),
('United Kingdom'),
('Spain'),
('Italy'),
('Netherlands');

-- Insertando datos iniciales en la tabla Providers
INSERT INTO Providers (nit, name, mail) VALUES 
('900987654-1', 'DataMasters', 'info@datamasters.com'),
('900876543-2', 'SysTech Solutions', 'support@systechsolutions.com'),
('900765432-3', 'InfiniSoft', 'contact@infinisoft.com'),
('900654321-4', 'MegaNet', 'service@meganet.com'),
('900543210-5', 'SmartWare', 'info@smartware.com'),
('900432109-6', 'TechWorld', 'contact@techworld.com'),
('900321098-7', 'ProLogic', 'service@prologic.com'),
('900210987-8', 'NetServe', 'support@netserve.com'),
('900109876-9', 'CloudNine', 'info@cloudnine.com'),
('900098765-0', 'TechEase', 'support@techease.com');

-- Insertando datos iniciales en la tabla Services
INSERT INTO Services (service) VALUES 
('Cloud Hosting'),
('Cybersecurity Audit'),
('Data Analytics'),
('AI Development'),
('IoT Solutions'),
('Blockchain Integration'),
('DevOps Consulting'),
('Mobile App Development'),
('IT Support Services'),
('Enterprise Software');

-- Insertando datos iniciales en la tabla Providers_Services
INSERT INTO Providers_Services (Providers_idprovider, Services_idservice, Country_idcountry, time_value) VALUES 
(1, 1, 1, 120000),
(1, 2, 2, 130000),
(2, 3, 3, 140000),
(3, 4, 4, 150000),
(4, 5, 5, 160000),
(5, 6, 6, 170000),
(6, 7, 7, 180000),
(7, 8, 8, 190000),
(8, 9, 9, 200000),
(9, 10, 10, 210000);
