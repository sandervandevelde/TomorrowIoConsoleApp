# Tomorrow.IO

## Introduction

This website and related API offers various weather data streams, including realtime and forecast data.

## Concerns

- What are the costs?
- Does this work worldwide, also in remote areas?
- Uses an API in the fat URL for a GET. This is insecure. Is there a more secure way of getting data?

## Fabric Support

The Tomorrow IO interface is also applicable in an [Fabric Eventstream HTTP source](images/eventstream-source.png)

## alternatives

### Azure Maps Weather via Fabric Eventstream

```
{
    "dateTime": "2026-02-01T20:41:00.0000000Z",
    "description": "Light rain",
    "iconCode": {
        "value": 12
    },
    "hasPrecipitation": true,
    "temperature": {
        "value": 6.6,
        "unitLabel": "C",
        "unitType": {
            "value": 17
        }
    },
    "realFeelTemperature": {
        "value": 4.4,
        "unitLabel": "C",
        "unitType": {
            "value": 17
        }
    },
    "realFeelTemperatureShade": {
        "value": 4.4,
        "unitLabel": "C",
        "unitType": {
            "value": 17
        }
    },
    "relativeHumidity": 93,
    "dewPoint": {
        "value": 5.6,
        "unitLabel": "C",
        "unitType": {
            "value": 17
        }
    },
    "wind": {
        "direction": {
            "description": "ESE",
            "degrees": 113
        },
        "speed": {
            "value": 11.1,
            "unitLabel": "km/h",
            "unitType": {
                "value": 7
            }
        }
    },
    "windGust": {
        "direction": null,
        "speed": {
            "value": 22,
            "unitLabel": "km/h",
            "unitType": {
                "value": 7
            }
        }
    },
    "uvIndex": 0,
    "uvIndexDescription": "Low",
    "visibility": {
        "value": 24.1,
        "unitLabel": "km",
        "unitType": {
            "value": 6
        }
    },
    "obstructionsToVisibility": "R-",
    "cloudCover": 92,
    "cloudCeiling": {
        "value": 6096,
        "unitLabel": "m",
        "unitType": {
            "value": 5
        }
    },
    "pressure": {
        "value": 1003.4,
        "unitLabel": "mb",
        "unitType": {
            "value": 14
        }
    },
    "pressureTendency": {
        "description": "Falling",
        "code": "F"
    },
    "pastTwentyFourHourTemperatureDeparture": null,
    "apparentTemperature": {
        "value": 8.3,
        "unitLabel": "C",
        "unitType": {
            "value": 17
        }
    },
    "windChillTemperature": {
        "value": 4.4,
        "unitLabel": "C",
        "unitType": {
            "value": 17
        }
    },
    "wetBulbTemperature": {
        "value": 6.2,
        "unitLabel": "C",
        "unitType": {
            "value": 17
        }
    },
    "precipitationSummary": {
        "pastHour": {
            "value": 0.5,
            "unitLabel": "mm",
            "unitType": {
                "value": 3
            }
        },
        "past3Hours": {
            "value": 0.5,
            "unitLabel": "mm",
            "unitType": {
                "value": 3
            }
        },
        "past6Hours": {
            "value": 1.3,
            "unitLabel": "mm",
            "unitType": {
                "value": 3
            }
        },
        "past9Hours": {
            "value": 3.3,
            "unitLabel": "mm",
            "unitType": {
                "value": 3
            }
        },
        "past12Hours": {
            "value": 5.1,
            "unitLabel": "mm",
            "unitType": {
                "value": 3
            }
        },
        "past18Hours": {
            "value": 5.1,
            "unitLabel": "mm",
            "unitType": {
                "value": 3
            }
        },
        "past24Hours": {
            "value": 5.1,
            "unitLabel": "mm",
            "unitType": {
                "value": 3
            }
        }
    },
    "temperatureSummary": {
        "past6Hours": {
            "minimum": {
                "value": 6.6,
                "unitLabel": "C",
                "unitType": {
                    "value": 17
                }
            },
            "maximum": {
                "value": 10,
                "unitLabel": "C",
                "unitType": {
                    "value": 17
                }
            }
        },
        "past12Hours": {
            "minimum": {
                "value": 3.9,
                "unitLabel": "C",
                "unitType": {
                    "value": 17
                }
            },
            "maximum": {
                "value": 10,
                "unitLabel": "C",
                "unitType": {
                    "value": 17
                }
            }
        },
        "past24Hours": {
            "minimum": {
                "value": 1.3,
                "unitLabel": "C",
                "unitType": {
                    "value": 17
                }
            },
            "maximum": {
                "value": 10,
                "unitLabel": "C",
                "unitType": {
                    "value": 17
                }
            }
        }
    },
    "daytime": false,
    "location": {
        "latitude": 51.47,
        "longitude": 5.65
    },
    "locationName": "HelmondWest"
}
```

## Links

* Website: https://app.tomorrow.io/home
* Where is the data coming from: https://support.tomorrow.io/hc/en-us/articles/5188641901460-How-Tomorrow-io-Collects-and-Uses-Weather-Data
* Talk to sales: https://www.tomorrow.io/lp/get-demo-resilience-5/
