-- SQL migrering for PostgreSQL

    -- Opprett Users-tabellen
CREATE TABLE Users (
    id UUID DEFAULT gen_random_uuid() PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    role VARCHAR(50) DEFAULT 'buyer' NOT NULL,
    created_at TIMESTAMP DEFAULT NOW() NOT NULL
);

-- Opprett Products-tabellen
CREATE TABLE Products (
    id UUID DEFAULT gen_random_uuid() PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    description TEXT NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    images JSONB NOT NULL,
    condition VARCHAR(50) NOT NULL CHECK (condition IN ('new', 'used')),
    category VARCHAR(50) NOT NULL,
    seller_id UUID NOT NULL REFERENCES Users(id) ON DELETE CASCADE,
    created_at TIMESTAMP DEFAULT NOW() NOT NULL
);

-- Index for raskere søk på Products
CREATE INDEX idx_products_category ON Products(category);
CREATE INDEX idx_products_price ON Products(price);