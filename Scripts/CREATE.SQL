-- Creación de la tabla Countries
CREATE TABLE Countries (
    idcountry INT IDENTITY(1,1) PRIMARY KEY,
    country NVARCHAR(255) NOT NULL
);

-- Creación de la tabla Providers
CREATE TABLE Providers (
    idprovider INT IDENTITY(1,1) PRIMARY KEY,
    nit NVARCHAR(20) NOT NULL,
    name NVARCHAR(255) NOT NULL,
    mail NVARCHAR(255) NOT NULL
);

-- Creación de la tabla Services
CREATE TABLE Services (
    idservice INT IDENTITY(1,1) PRIMARY KEY,
    service NVARCHAR(255) NOT NULL
);

-- Creación de la tabla Providers_Services
CREATE TABLE Providers_Services (
    Providers_idprovider INT,
    Services_idservice INT,
    Country_idcountry INT,
    time_value FLOAT NOT NULL,
    PRIMARY KEY (Providers_idprovider, Services_idservice, Country_idcountry),
    FOREIGN KEY (Providers_idprovider) REFERENCES Providers(idprovider) ON DELETE CASCADE,
    FOREIGN KEY (Services_idservice) REFERENCES Services(idservice) ON DELETE CASCADE,
    FOREIGN KEY (Country_idcountry) REFERENCES Countries(idcountry) ON DELETE CASCADE
);
