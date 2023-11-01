# data-sync-multi-system
Multi-peer data synchronization library for desktop or mobile clients without a centralized database.

## Data Storage
- Single file database.
- Changes stored in seperate files with unique GUID.

### Availability
- Prevent app blocking on clients.

## Synchronization Mechanism
- Event to trigger synchronization.

## Data Transfer
- Timestamping data will be needed to ensure only data since the last successful sync has been updated.