﻿/*
* Licensed to Apereo under one or more contributor license
* agreements. See the NOTICE file distributed with this work
* for additional information regarding copyright ownership.
* Apereo licenses this file to you under the Apache License,
* Version 2.0 (the "License"); you may not use this file
* except in compliance with the License. You may obtain a
* copy of the License at:
* 
* http://www.apache.org/licenses/LICENSE-2.0
* 
* Unless required by applicable law or agreed to in writing,
* software distributed under the License is distributed on
* an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
* KIND, either express or implied. See the License for the
* specific language governing permissions and limitations
* under the License.
*/

#pragma warning disable 1591

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using DotNetCoreCas.Validation.Schema.XmlDsig;

namespace DotNetCoreCas.Validation.Schema.Saml20.Metadata
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:tc:SAML:2.0:metadata")]
    [XmlRoot("AffiliationDescriptor", Namespace="urn:oasis:names:tc:SAML:2.0:metadata", IsNullable=false)]
    public class AffiliationDescriptorType {
        [XmlElement(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get;
            set;
        }

        public ExtensionsType Extensions
        {
            get;
            set;
        }

        [XmlElement("AffiliateMember", DataType="anyURI")]
        public string[] AffiliateMember
        {
            get;
            set;
        }

        [XmlElement("KeyDescriptor")]
        public KeyDescriptorType[] KeyDescriptor
        {
            get;
            set;
        }

        [XmlAttribute("affiliationOwnerID", DataType="anyURI")]
        public string AffiliationOwnerId
        {
            get;
            set;
        }

        [XmlAttribute("validUntil")]
        public DateTime ValidUntil
        {
            get;
            set;
        }

        [XmlIgnore]
        public bool ValidUntilSpecified
        {
            get;
            set;
        }

        [XmlAttribute("cacheDuration", DataType="duration")]
        public string CacheDuration
        {
            get;
            set;
        }

        [XmlAttribute("ID", DataType="ID")]
        public string Id
        {
            get;
            set;
        }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttr
        {
            get;
            set;
        }
    }
}

#pragma warning restore 1591