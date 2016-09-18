using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightIISServices.Entity
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PSW5
    {

        private byte aLT_COUField;

        private PSW5ALT_INF[] aLT_INFField;

        private string trackingidField;

        /// <remarks/>
        public byte ALT_COU
        {
            get
            {
                return this.aLT_COUField;
            }
            set
            {
                this.aLT_COUField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ALT_INF")]
        public PSW5ALT_INF[] ALT_INF
        {
            get
            {
                return this.aLT_INFField;
            }
            set
            {
                this.aLT_INFField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string trackingid
        {
            get
            {
                return this.trackingidField;
            }
            set
            {
                this.trackingidField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PSW5ALT_INF
    {

        private decimal bAS_FARField;

        private decimal tAXField;

        private decimal tTL_FARField;

        private string iSO_CUR_CODField;

        private string fAR_SELField;

        private string vAL_CARField;

        private PSW5ALT_INFPTC_FAR_INF pTC_FAR_INFField;

        private PSW5ALT_INFFARE_PER_PTC fARE_PER_PTCField;

        private PSW5ALT_INFTTL_FARE_INF tTL_FARE_INFField;

        private string lAS_TIC_DATField;

        private PSW5ALT_INFFLI_INF[] fLI_INFField;

        private PSW5ALT_INFTRI_INF[] tRI_INFField;

        /// <remarks/>
        public decimal BAS_FAR
        {
            get
            {
                return this.bAS_FARField;
            }
            set
            {
                this.bAS_FARField = value;
            }
        }

        /// <remarks/>
        public decimal TAX
        {
            get
            {
                return this.tAXField;
            }
            set
            {
                this.tAXField = value;
            }
        }

        /// <remarks/>
        public decimal TTL_FAR
        {
            get
            {
                return this.tTL_FARField;
            }
            set
            {
                this.tTL_FARField = value;
            }
        }

        /// <remarks/>
        public string ISO_CUR_COD
        {
            get
            {
                return this.iSO_CUR_CODField;
            }
            set
            {
                this.iSO_CUR_CODField = value;
            }
        }

        /// <remarks/>
        public string FAR_SEL
        {
            get
            {
                return this.fAR_SELField;
            }
            set
            {
                this.fAR_SELField = value;
            }
        }

        /// <remarks/>
        public string VAL_CAR
        {
            get
            {
                return this.vAL_CARField;
            }
            set
            {
                this.vAL_CARField = value;
            }
        }

        /// <remarks/>
        public PSW5ALT_INFPTC_FAR_INF PTC_FAR_INF
        {
            get
            {
                return this.pTC_FAR_INFField;
            }
            set
            {
                this.pTC_FAR_INFField = value;
            }
        }

        /// <remarks/>
        public PSW5ALT_INFFARE_PER_PTC FARE_PER_PTC
        {
            get
            {
                return this.fARE_PER_PTCField;
            }
            set
            {
                this.fARE_PER_PTCField = value;
            }
        }

        /// <remarks/>
        public PSW5ALT_INFTTL_FARE_INF TTL_FARE_INF
        {
            get
            {
                return this.tTL_FARE_INFField;
            }
            set
            {
                this.tTL_FARE_INFField = value;
            }
        }

        /// <remarks/>
        public string LAS_TIC_DAT
        {
            get
            {
                return this.lAS_TIC_DATField;
            }
            set
            {
                this.lAS_TIC_DATField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FLI_INF")]
        public PSW5ALT_INFFLI_INF[] FLI_INF
        {
            get
            {
                return this.fLI_INFField;
            }
            set
            {
                this.fLI_INFField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TRI_INF")]
        public PSW5ALT_INFTRI_INF[] TRI_INF
        {
            get
            {
                return this.tRI_INFField;
            }
            set
            {
                this.tRI_INFField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PSW5ALT_INFPTC_FAR_INF
    {

        private string pTCField;

        private byte nUM_PAXField;

        private decimal bAS_FARField;

        private decimal tTL_FARField;

        /// <remarks/>
        public string PTC
        {
            get
            {
                return this.pTCField;
            }
            set
            {
                this.pTCField = value;
            }
        }

        /// <remarks/>
        public byte NUM_PAX
        {
            get
            {
                return this.nUM_PAXField;
            }
            set
            {
                this.nUM_PAXField = value;
            }
        }

        /// <remarks/>
        public decimal BAS_FAR
        {
            get
            {
                return this.bAS_FARField;
            }
            set
            {
                this.bAS_FARField = value;
            }
        }

        /// <remarks/>
        public decimal TTL_FAR
        {
            get
            {
                return this.tTL_FARField;
            }
            set
            {
                this.tTL_FARField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PSW5ALT_INFFARE_PER_PTC
    {

        private byte nUM_PAXField;

        private string pTCField;

        private decimal bAS_FARField;

        private decimal tTL_TAX_AMTField;

        private decimal tTL_FARE_AMTField;

        /// <remarks/>
        public byte NUM_PAX
        {
            get
            {
                return this.nUM_PAXField;
            }
            set
            {
                this.nUM_PAXField = value;
            }
        }

        /// <remarks/>
        public string PTC
        {
            get
            {
                return this.pTCField;
            }
            set
            {
                this.pTCField = value;
            }
        }

        /// <remarks/>
        public decimal BAS_FAR
        {
            get
            {
                return this.bAS_FARField;
            }
            set
            {
                this.bAS_FARField = value;
            }
        }

        /// <remarks/>
        public decimal TTL_TAX_AMT
        {
            get
            {
                return this.tTL_TAX_AMTField;
            }
            set
            {
                this.tTL_TAX_AMTField = value;
            }
        }

        /// <remarks/>
        public decimal TTL_FARE_AMT
        {
            get
            {
                return this.tTL_FARE_AMTField;
            }
            set
            {
                this.tTL_FARE_AMTField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PSW5ALT_INFTTL_FARE_INF
    {

        private decimal tTL_BAS_AMTField;

        private decimal tTL_TAX_AMTField;

        private decimal tTL_FARE_AMTField;

        /// <remarks/>
        public decimal TTL_BAS_AMT
        {
            get
            {
                return this.tTL_BAS_AMTField;
            }
            set
            {
                this.tTL_BAS_AMTField = value;
            }
        }

        /// <remarks/>
        public decimal TTL_TAX_AMT
        {
            get
            {
                return this.tTL_TAX_AMTField;
            }
            set
            {
                this.tTL_TAX_AMTField = value;
            }
        }

        /// <remarks/>
        public decimal TTL_FARE_AMT
        {
            get
            {
                return this.tTL_FARE_AMTField;
            }
            set
            {
                this.tTL_FARE_AMTField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PSW5ALT_INFFLI_INF
    {

        private string aRL_CODField;

        private ushort fLI_NUMField;

        private string fAR_CLAField;

        private byte nUM_SEAField;

        private string fLI_DATField;

        private string fLI_DAYField;

        private string dEP_ARPField;

        private string aRR_ARPField;

        private ushort dEP_TIMField;

        private ushort aRR_TIMField;

        private string eQP_TYPField;

        private byte nUM_STOField;

        private string e_TIC_ELIField;

        private string cOD_SHA_INFField;

        private string iNV_CONField;

        private PSW5ALT_INFFLI_INFADD_FLI_SVC aDD_FLI_SVCField;

        /// <remarks/>
        public string ARL_COD
        {
            get
            {
                return this.aRL_CODField;
            }
            set
            {
                this.aRL_CODField = value;
            }
        }

        /// <remarks/>
        public ushort FLI_NUM
        {
            get
            {
                return this.fLI_NUMField;
            }
            set
            {
                this.fLI_NUMField = value;
            }
        }

        /// <remarks/>
        public string FAR_CLA
        {
            get
            {
                return this.fAR_CLAField;
            }
            set
            {
                this.fAR_CLAField = value;
            }
        }

        /// <remarks/>
        public byte NUM_SEA
        {
            get
            {
                return this.nUM_SEAField;
            }
            set
            {
                this.nUM_SEAField = value;
            }
        }

        /// <remarks/>
        public string FLI_DAT
        {
            get
            {
                return this.fLI_DATField;
            }
            set
            {
                this.fLI_DATField = value;
            }
        }

        /// <remarks/>
        public string FLI_DAY
        {
            get
            {
                return this.fLI_DAYField;
            }
            set
            {
                this.fLI_DAYField = value;
            }
        }

        /// <remarks/>
        public string DEP_ARP
        {
            get
            {
                return this.dEP_ARPField;
            }
            set
            {
                this.dEP_ARPField = value;
            }
        }

        /// <remarks/>
        public string ARR_ARP
        {
            get
            {
                return this.aRR_ARPField;
            }
            set
            {
                this.aRR_ARPField = value;
            }
        }

        /// <remarks/>
        public ushort DEP_TIM
        {
            get
            {
                return this.dEP_TIMField;
            }
            set
            {
                this.dEP_TIMField = value;
            }
        }

        /// <remarks/>
        public ushort ARR_TIM
        {
            get
            {
                return this.aRR_TIMField;
            }
            set
            {
                this.aRR_TIMField = value;
            }
        }

        /// <remarks/>
        public string EQP_TYP
        {
            get
            {
                return this.eQP_TYPField;
            }
            set
            {
                this.eQP_TYPField = value;
            }
        }

        /// <remarks/>
        public byte NUM_STO
        {
            get
            {
                return this.nUM_STOField;
            }
            set
            {
                this.nUM_STOField = value;
            }
        }

        /// <remarks/>
        public string E_TIC_ELI
        {
            get
            {
                return this.e_TIC_ELIField;
            }
            set
            {
                this.e_TIC_ELIField = value;
            }
        }

        /// <remarks/>
        public string COD_SHA_INF
        {
            get
            {
                return this.cOD_SHA_INFField;
            }
            set
            {
                this.cOD_SHA_INFField = value;
            }
        }

        /// <remarks/>
        public string INV_CON
        {
            get
            {
                return this.iNV_CONField;
            }
            set
            {
                this.iNV_CONField = value;
            }
        }

        /// <remarks/>
        public PSW5ALT_INFFLI_INFADD_FLI_SVC ADD_FLI_SVC
        {
            get
            {
                return this.aDD_FLI_SVCField;
            }
            set
            {
                this.aDD_FLI_SVCField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PSW5ALT_INFFLI_INFADD_FLI_SVC
    {

        private byte dEP_TERField;

        private bool dEP_TERFieldSpecified;

        private byte aRR_TERField;

        private bool aRR_TERFieldSpecified;

        private string dOT_PERField;

        private byte lEG_MILField;

        private byte gRO_TIMField;

        private bool gRO_TIMFieldSpecified;

        private ushort eLA_FLI_TIMField;

        private ushort aCU_FLI_TIMField;

        /// <remarks/>
        public byte DEP_TER
        {
            get
            {
                return this.dEP_TERField;
            }
            set
            {
                this.dEP_TERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DEP_TERSpecified
        {
            get
            {
                return this.dEP_TERFieldSpecified;
            }
            set
            {
                this.dEP_TERFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte ARR_TER
        {
            get
            {
                return this.aRR_TERField;
            }
            set
            {
                this.aRR_TERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ARR_TERSpecified
        {
            get
            {
                return this.aRR_TERFieldSpecified;
            }
            set
            {
                this.aRR_TERFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string DOT_PER
        {
            get
            {
                return this.dOT_PERField;
            }
            set
            {
                this.dOT_PERField = value;
            }
        }

        /// <remarks/>
        public byte LEG_MIL
        {
            get
            {
                return this.lEG_MILField;
            }
            set
            {
                this.lEG_MILField = value;
            }
        }

        /// <remarks/>
        public byte GRO_TIM
        {
            get
            {
                return this.gRO_TIMField;
            }
            set
            {
                this.gRO_TIMField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GRO_TIMSpecified
        {
            get
            {
                return this.gRO_TIMFieldSpecified;
            }
            set
            {
                this.gRO_TIMFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ushort ELA_FLI_TIM
        {
            get
            {
                return this.eLA_FLI_TIMField;
            }
            set
            {
                this.eLA_FLI_TIMField = value;
            }
        }

        /// <remarks/>
        public ushort ACU_FLI_TIM
        {
            get
            {
                return this.aCU_FLI_TIMField;
            }
            set
            {
                this.aCU_FLI_TIMField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PSW5ALT_INFTRI_INF
    {

        private string[] aRP_CODField;

        private PSW5ALT_INFTRI_INFMKT_PUL mKT_PULField;

        private PSW5ALT_INFTRI_INFPTC_DTL_INF pTC_DTL_INFField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ARP_COD")]
        public string[] ARP_COD
        {
            get
            {
                return this.aRP_CODField;
            }
            set
            {
                this.aRP_CODField = value;
            }
        }

        /// <remarks/>
        public PSW5ALT_INFTRI_INFMKT_PUL MKT_PUL
        {
            get
            {
                return this.mKT_PULField;
            }
            set
            {
                this.mKT_PULField = value;
            }
        }

        /// <remarks/>
        public PSW5ALT_INFTRI_INFPTC_DTL_INF PTC_DTL_INF
        {
            get
            {
                return this.pTC_DTL_INFField;
            }
            set
            {
                this.pTC_DTL_INFField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PSW5ALT_INFTRI_INFMKT_PUL
    {

        private string oRIField;

        private string dESField;

        /// <remarks/>
        public string ORI
        {
            get
            {
                return this.oRIField;
            }
            set
            {
                this.oRIField = value;
            }
        }

        /// <remarks/>
        public string DES
        {
            get
            {
                return this.dESField;
            }
            set
            {
                this.dESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PSW5ALT_INFTRI_INFPTC_DTL_INF
    {

        private string pTCField;

        private string aRL_CODField;

        private string fAR_RSTField;

        private string fAR_BAS_CODField;

        /// <remarks/>
        public string PTC
        {
            get
            {
                return this.pTCField;
            }
            set
            {
                this.pTCField = value;
            }
        }

        /// <remarks/>
        public string ARL_COD
        {
            get
            {
                return this.aRL_CODField;
            }
            set
            {
                this.aRL_CODField = value;
            }
        }

        /// <remarks/>
        public string FAR_RST
        {
            get
            {
                return this.fAR_RSTField;
            }
            set
            {
                this.fAR_RSTField = value;
            }
        }

        /// <remarks/>
        public string FAR_BAS_COD
        {
            get
            {
                return this.fAR_BAS_CODField;
            }
            set
            {
                this.fAR_BAS_CODField = value;
            }
        }
    }


}