using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightIISServices.Entity
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05", IsNullable = false)]
    public partial class OTA_AirLowFareSearchRS
    {

        private object successField;

        private OTA_AirLowFareSearchRSPricedItinerary[] pricedItinerariesField;

        private string versionField;

        /// <remarks/>
        public object Success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PricedItinerary", IsNullable = false)]
        public OTA_AirLowFareSearchRSPricedItinerary[] PricedItineraries
        {
            get
            {
                return this.pricedItinerariesField;
            }
            set
            {
                this.pricedItinerariesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItinerary
    {

        private bool isCardPayField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfo airItineraryInfoField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfo airItineraryPricingInfoField;

        private OTA_AirLowFareSearchRSPricedItineraryTicketingInfo ticketingInfoField;

        private OTA_AirLowFareSearchRSPricedItineraryTPA_Extensions tPA_ExtensionsField;

        private byte sequenceNumberField;

        /// <remarks/>
        public bool IsCardPay
        {
            get
            {
                return this.isCardPayField;
            }
            set
            {
                this.isCardPayField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfo AirItineraryInfo
        {
            get
            {
                return this.airItineraryInfoField;
            }
            set
            {
                this.airItineraryInfoField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfo AirItineraryPricingInfo
        {
            get
            {
                return this.airItineraryPricingInfoField;
            }
            set
            {
                this.airItineraryPricingInfoField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryTicketingInfo TicketingInfo
        {
            get
            {
                return this.ticketingInfoField;
            }
            set
            {
                this.ticketingInfoField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryTPA_Extensions TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SequenceNumber
        {
            get
            {
                return this.sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfo
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOption[] originDestinationOptionsField;

        private string directionIndField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OriginDestinationOption", IsNullable = false)]
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOption[] OriginDestinationOptions
        {
            get
            {
                return this.originDestinationOptionsField;
            }
            set
            {
                this.originDestinationOptionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DirectionInd
        {
            get
            {
                return this.directionIndField;
            }
            set
            {
                this.directionIndField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOption
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegment flightSegmentField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegment FlightSegment
        {
            get
            {
                return this.flightSegmentField;
            }
            set
            {
                this.flightSegmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegment
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentDepartureAirport departureAirportField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentArrivalAirport arrivalAirportField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentOperatingAirline operatingAirlineField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentEquipment equipmentField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentMarketingAirline marketingAirlineField;

        private object marriageGrpField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_Extensions tPA_ExtensionsField;

        private System.DateTime departureDateTimeField;

        private System.DateTime arrivalDateTimeField;

        private byte stopQuantityField;

        private ushort flightNumberField;

        private string resBookDesigCodeField;

        private byte journeyDurationField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentDepartureAirport DepartureAirport
        {
            get
            {
                return this.departureAirportField;
            }
            set
            {
                this.departureAirportField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentArrivalAirport ArrivalAirport
        {
            get
            {
                return this.arrivalAirportField;
            }
            set
            {
                this.arrivalAirportField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentOperatingAirline OperatingAirline
        {
            get
            {
                return this.operatingAirlineField;
            }
            set
            {
                this.operatingAirlineField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentEquipment Equipment
        {
            get
            {
                return this.equipmentField;
            }
            set
            {
                this.equipmentField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentMarketingAirline MarketingAirline
        {
            get
            {
                return this.marketingAirlineField;
            }
            set
            {
                this.marketingAirlineField = value;
            }
        }

        /// <remarks/>
        public object MarriageGrp
        {
            get
            {
                return this.marriageGrpField;
            }
            set
            {
                this.marriageGrpField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_Extensions TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DepartureDateTime
        {
            get
            {
                return this.departureDateTimeField;
            }
            set
            {
                this.departureDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this.arrivalDateTimeField;
            }
            set
            {
                this.arrivalDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte StopQuantity
        {
            get
            {
                return this.stopQuantityField;
            }
            set
            {
                this.stopQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort FlightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResBookDesigCode
        {
            get
            {
                return this.resBookDesigCodeField;
            }
            set
            {
                this.resBookDesigCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte JourneyDuration
        {
            get
            {
                return this.journeyDurationField;
            }
            set
            {
                this.journeyDurationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentDepartureAirport
    {

        private string locationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentArrivalAirport
    {

        private string locationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentOperatingAirline
    {

        private string codeField;

        private ushort flightNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort FlightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentEquipment
    {

        private string airEquipTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirEquipType
        {
            get
            {
                return this.airEquipTypeField;
            }
            set
            {
                this.airEquipTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentMarketingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_Extensions
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_ExtensionsETicket eTicketField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_ExtensionsCabinClass cabinClassField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_ExtensionsMeal mealField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_ExtensionsSeatsRemaining seatsRemainingField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_ExtensionsETicket eTicket
        {
            get
            {
                return this.eTicketField;
            }
            set
            {
                this.eTicketField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_ExtensionsCabinClass CabinClass
        {
            get
            {
                return this.cabinClassField;
            }
            set
            {
                this.cabinClassField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_ExtensionsMeal Meal
        {
            get
            {
                return this.mealField;
            }
            set
            {
                this.mealField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_ExtensionsSeatsRemaining SeatsRemaining
        {
            get
            {
                return this.seatsRemainingField;
            }
            set
            {
                this.seatsRemainingField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_ExtensionsETicket
    {

        private string indField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ind
        {
            get
            {
                return this.indField;
            }
            set
            {
                this.indField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_ExtensionsCabinClass
    {

        private string cabinTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CabinTypeCode
        {
            get
            {
                return this.cabinTypeCodeField;
            }
            set
            {
                this.cabinTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_ExtensionsMeal
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryInfoOriginDestinationOptionFlightSegmentTPA_ExtensionsSeatsRemaining
    {

        private byte numberField;

        private string belowMinField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BelowMin
        {
            get
            {
                return this.belowMinField;
            }
            set
            {
                this.belowMinField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfo
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFare itinTotalFareField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdown[] pTC_FareBreakdownsField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfo[] fareInfosField;

        private string fareTypeField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_Extensions tPA_ExtensionsField;

        private string fareSourceCodeField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFare ItinTotalFare
        {
            get
            {
                return this.itinTotalFareField;
            }
            set
            {
                this.itinTotalFareField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PTC_FareBreakdown", IsNullable = false)]
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdown[] PTC_FareBreakdowns
        {
            get
            {
                return this.pTC_FareBreakdownsField;
            }
            set
            {
                this.pTC_FareBreakdownsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FareInfo", IsNullable = false)]
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfo[] FareInfos
        {
            get
            {
                return this.fareInfosField;
            }
            set
            {
                this.fareInfosField = value;
            }
        }

        /// <remarks/>
        public string FareType
        {
            get
            {
                return this.fareTypeField;
            }
            set
            {
                this.fareTypeField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_Extensions TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FareSourceCode
        {
            get
            {
                return this.fareSourceCodeField;
            }
            set
            {
                this.fareSourceCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFare
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareBaseFare baseFareField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareEquivFare equivFareField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTotalTax totalTaxField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTotalFare totalFareField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareBaseFare BaseFare
        {
            get
            {
                return this.baseFareField;
            }
            set
            {
                this.baseFareField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareEquivFare EquivFare
        {
            get
            {
                return this.equivFareField;
            }
            set
            {
                this.equivFareField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTotalTax TotalTax
        {
            get
            {
                return this.totalTaxField;
            }
            set
            {
                this.totalTaxField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTotalFare TotalFare
        {
            get
            {
                return this.totalFareField;
            }
            set
            {
                this.totalFareField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareBaseFare
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareEquivFare
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTotalTax
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoItinTotalFareTotalFare
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdown
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerTypeQuantity passengerTypeQuantityField;

        private string[] fareBasisCodesField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFare passengerFareField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerTypeQuantity PassengerTypeQuantity
        {
            get
            {
                return this.passengerTypeQuantityField;
            }
            set
            {
                this.passengerTypeQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FareBasisCode", IsNullable = false)]
        public string[] FareBasisCodes
        {
            get
            {
                return this.fareBasisCodesField;
            }
            set
            {
                this.fareBasisCodesField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFare PassengerFare
        {
            get
            {
                return this.passengerFareField;
            }
            set
            {
                this.passengerFareField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerTypeQuantity
    {

        private string codeField;

        private byte quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFare
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareBaseFare baseFareField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareEquivFare equivFareField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTaxes taxesField;

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTotalFare totalFareField;

        private object tPA_ExtensionsField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareBaseFare BaseFare
        {
            get
            {
                return this.baseFareField;
            }
            set
            {
                this.baseFareField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareEquivFare EquivFare
        {
            get
            {
                return this.equivFareField;
            }
            set
            {
                this.equivFareField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTaxes Taxes
        {
            get
            {
                return this.taxesField;
            }
            set
            {
                this.taxesField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTotalFare TotalFare
        {
            get
            {
                return this.totalFareField;
            }
            set
            {
                this.totalFareField = value;
            }
        }

        /// <remarks/>
        public object TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareBaseFare
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareEquivFare
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTaxes
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTaxesTax taxField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTaxesTax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTaxesTax
    {

        private decimal amountField;

        private string currencyCodeField;

        private string taxCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TaxCode
        {
            get
            {
                return this.taxCodeField;
            }
            set
            {
                this.taxCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoPTC_FareBreakdownPassengerFareTotalFare
    {

        private decimal amountField;

        private string currencyCodeField;

        private byte decimalPlacesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoFareInfo
    {

        private string fareReferenceField;

        /// <remarks/>
        public string FareReference
        {
            get
            {
                return this.fareReferenceField;
            }
            set
            {
                this.fareReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_Extensions
    {

        private OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_ExtensionsDivideInParty divideInPartyField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_ExtensionsDivideInParty DivideInParty
        {
            get
            {
                return this.divideInPartyField;
            }
            set
            {
                this.divideInPartyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryAirItineraryPricingInfoTPA_ExtensionsDivideInParty
    {

        private bool indicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Indicator
        {
            get
            {
                return this.indicatorField;
            }
            set
            {
                this.indicatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryTicketingInfo
    {

        private string ticketTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketType
        {
            get
            {
                return this.ticketTypeField;
            }
            set
            {
                this.ticketTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryTPA_Extensions
    {

        private OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsValidatingAirline validatingAirlineField;

        private OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsPassport passportField;

        private OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsRequiredFieldsToBook requiredFieldsToBookField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsValidatingAirline ValidatingAirline
        {
            get
            {
                return this.validatingAirlineField;
            }
            set
            {
                this.validatingAirlineField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsPassport Passport
        {
            get
            {
                return this.passportField;
            }
            set
            {
                this.passportField = value;
            }
        }

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsRequiredFieldsToBook RequiredFieldsToBook
        {
            get
            {
                return this.requiredFieldsToBookField;
            }
            set
            {
                this.requiredFieldsToBookField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsValidatingAirline
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsPassport
    {

        private string indField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ind
        {
            get
            {
                return this.indField;
            }
            set
            {
                this.indField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsRequiredFieldsToBook
    {

        private OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsRequiredFieldsToBookItem itemField;

        /// <remarks/>
        public OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsRequiredFieldsToBookItem Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_AirLowFareSearchRSPricedItineraryTPA_ExtensionsRequiredFieldsToBookItem
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}