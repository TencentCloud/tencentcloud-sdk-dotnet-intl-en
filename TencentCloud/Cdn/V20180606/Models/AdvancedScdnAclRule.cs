/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvancedScdnAclRule : AbstractModel
    {
        
        /// <summary>
        /// Keyword. Valid values:
        /// `protocol`: HTTP protocol
        /// `httpVersion`: HTTP version
        /// `method`: request method
        /// `ip`: requester IP
        /// `ipAsn`: ASN of the requester IP
        /// `ipCountry`: country/region of the requester IP
        /// `ipArea`: region of the requester IP
        /// `xForwardFor`: X-Forward-For request header
        /// `directory`: Path
        /// `index`: Homepage
        /// `path`: Full path of a file
        /// `file`: File extension
        /// `param`: Request parameter
        /// `referer`: Referer request header
        /// `cookie`: Cookie request header
        /// `userAgent`: User-Agent request header
        /// `head`: Custom request header
        /// </summary>
        [JsonProperty("MatchKey")]
        public string MatchKey{ get; set; }

        /// <summary>
        /// Logical operator. Valid values:
        /// `exclude`: The keyword is not included
        /// `include`: The keyword is included
        /// `notequal`: Not the same as the keyword
        /// `equal`: The same as the keyword
        /// `matching`: The prefix is matched
        /// `null`: Empty or does not exist
        /// </summary>
        [JsonProperty("LogicOperator")]
        public string LogicOperator{ get; set; }

        /// <summary>
        /// Matched value.
        /// When `MatchKey` is `protocol`,
        /// Values: `HTTP` and `HTTPS`.
        /// 
        /// When `MatchKey` is `httpVersion`,
        /// Values: `HTTP/1.0`, `HTTP/1.1`, `HTTP/1.2`, `HTTP/2`, and `HTTP/3`.
        /// 
        /// When `MatchKey` is `method`,
        /// Values: `HEAD`, `GET`, `POST`, `PUT`, `OPTIONS`, `TRACE`, `DELETE`, `PATCH` and `CONNECT`.
        /// 
        /// When `MatchKey` is `ipCountry`, valid values include:
        /// `OTHER`: Other areas
        /// `VE`: Venezuela
        /// `UY`: Uruguay
        /// `SR`: Suriname
        /// `PY`: Paraguay
        /// `PE`: Peru
        /// `GY`: Guyana
        /// `EC`: Ecuador
        /// `CO`: Colombia
        /// `CL`: Chile
        /// `BR`: Brazil
        /// `BO`: Bolivia
        /// `AR`: Argentina
        /// `NZ`: New Zealand
        /// `WS`: Samoa
        /// `VU`: Vanuatu
        /// `TV`: Tuvalu
        /// `TO`: Tonga
        /// `TK`: Tokelau
        /// `PW`: Palau
        /// `NU`: Niue
        /// `NR`: Nauru
        /// `KI`: Kiribati
        /// `GU`: Guam
        /// `FM`: Micronesia
        /// `AU`: Australia
        /// `US`: United States
        /// `PR`: Puerto Rico
        /// `DO`: Dominican Republic
        /// `CR`: Costa Rica
        /// `AS`: American Samoa
        /// `AG`: Antigua and Barbuda
        /// `PA`: Panama
        /// `NI`: Nicaragua
        /// `MX`: Mexico
        /// `JM`: Jamaica
        /// `HT`: Haiti
        /// `HN`: Honduras
        /// `GT`: Guatemala
        /// `GP`: Guadeloupe
        /// `GL`: Greenland
        /// `GD`: Grenada
        /// `CU`: Cuba
        /// `CA`: Canada
        /// `BZ`: Belize
        /// `BS`: Bahamas
        /// `BM`: Bermuda
        /// `BB`: Barbados
        /// `AW`: Aruba
        /// `AI`: Anguilla
        /// `VA`: Vatican
        /// `SK`: Slovakia
        /// `GB`: United Kingdom
        /// `CZ`: Czech Republic
        /// `UA`: Ukraine
        /// `TR`: Türkiye
        /// `SI`: Slovenia
        /// `SE`: Sweden
        /// `RS`: Republic of Serbia
        /// `RO`: Romania
        /// `PT`: Portugal
        /// `PL`: Poland
        /// `NO`: Norway
        /// `NL`: Netherlands
        /// `MT`: Malta
        /// `MK`: Macedonia
        /// `ME`: Montenegro
        /// `MD`: Moldova
        /// `MC`: Monaco
        /// `LV`: Latvia
        /// `LU`: Luxembourg
        /// `LT`: Lithuania
        /// `LI`: Liechtenstein
        /// `KZ`: Kazakhstan
        /// `IT`: Italy
        /// `IS`: Iceland
        /// `IE`: Ireland
        /// `HU`: Hungary
        /// `HR`: Croatia
        /// `GR`: Greece
        /// `GI`: Gibraltar
        /// `GG`: Guernsey
        /// `GE`: Georgia
        /// `FR`: France
        /// `FI`: Finland
        /// `ES`: Spain
        /// `EE`: Estonia
        /// `DK`: Denmark
        /// `DE`: Germany
        /// `CY`: Cyprus
        /// `CH`: Switzerland
        /// `BY`: Belarus
        /// `BG`: Bulgaria
        /// `BE`: Belgium
        /// `AZ`: Azerbaijan
        /// `AT`: Austria
        /// `AM`: Armenia
        /// `AL`: Albania
        /// `AD`: Andorra
        /// `TL`: East Timor
        /// `SY`: Syria
        /// `SA`: Saudi Arabia
        /// `PS`: Palestine
        /// `LK`: Sri Lanka
        /// `LK`: Sri Lanka
        /// `KP`: North Korea
        /// `KG`: Kyrgyzstan
        /// `HK`: Hong Kong, China
        /// `BN`: Brunei
        /// `BD`: Bangladesh
        /// `AE`: United Arab Emirates
        /// `YE`: Yemen
        /// `VN`: Vietnam
        /// `UZ`: Uzbekistan
        /// `TW`: Taiwan, China
        /// `TM`: Turkmenistan
        /// `TJ`: Tajikistan
        /// `TH`: Thailand
        /// `SG`: Singapore
        /// `QA`: Qatar
        /// `PK`: Pakistan
        /// `PH`: Philippines
        /// `OM`: Oman
        /// `NP`: Nepal
        /// `MY`: Malaysia
        /// `MV`: Maldives
        /// `MO`: Macao, China
        /// `MN`: Mongolia
        /// `MM`: Myanmar
        /// `LB`: Lebanon
        /// `KW`: Kuwait
        /// `KR`: South Korea
        /// `KH`: Cambodia
        /// `JP`: Japan
        /// `JO`: Jordan
        /// `IR`: Iran
        /// `IQ`: Iraq
        /// `IN`: India
        /// `IL`: Israel
        /// `ID`: Indonesia
        /// `CN`: China
        /// `BT`: Bhutan
        /// `BH`: Bahrain
        /// `AF`: Afghanistan
        /// `LY`: Libya
        /// `CD`: Democratic Republic of the Congo
        /// `RE`: La Réunion
        /// `SZ`: Swaziland
        /// `ZW`: Zimbabwe
        /// `ZM`: Zambia
        /// `YT`: Mayotte
        /// `UG`: Uganda
        /// `TZ`: Tanzania
        /// `TN`: Tunisia
        /// `TG`: Togo
        /// `TD`: Chad
        /// `SO`: Somalia
        /// `SN`: Senegal
        /// `SD`: Sudan
        /// `SC`: Seychelles
        /// `RW`: Rwanda
        /// `NG`: Nigeria
        /// `NE`: Niger
        /// `NA`: Namibia
        /// `MZ`: Mozambique
        /// `MW`: Malawi
        /// `MU`: Mauritius
        /// `MR`: Mauritania
        /// `ML`: Mali
        /// `MG`: Madagascar
        /// `MA`: Morocco
        /// `LS`: Lesotho
        /// `LR`: Liberia
        /// `KM`: Comoros
        /// `KE`: Kenya
        /// `GN`: Guinea
        /// `GM`: Gambia
        /// `GH`: Ghana
        /// `GA`: Gabon
        /// `ET`: Ethiopia
        /// `ER`: Eritrea
        /// `EG`: Egypt
        /// `DZ`: Algeria
        /// `DJ`: Djibouti
        /// `CM`: Cameroon
        /// `CG`: Republic of the Congo
        /// `BW`: Botswana
        /// `BJ`: Benin
        /// `BI`: Burundi
        /// `AO`: Angola
        /// 
        /// When MatchKey is `ipArea`, valid values include:
        /// `OTHER`: Other areas
        /// `AS`: Asia
        /// `EU`: Europe
        /// `AN`: Antarctica
        /// `AF`: Africa
        /// `OC`: Oceania
        /// `NA`: North America
        /// `SA`: South America
        /// 
        /// When MatchKey is `index`,
        /// valid value is `/;/index.html`.
        /// </summary>
        [JsonProperty("MatchValue")]
        public string[] MatchValue{ get; set; }

        /// <summary>
        /// Whether to distinguish uppercase or lowercase letters. `true`: case sensitive; `false`: case insensitive.
        /// </summary>
        [JsonProperty("CaseSensitive")]
        public bool? CaseSensitive{ get; set; }

        /// <summary>
        /// This field is required when `MatchKey` is `param` or `cookie`. For `param`, it indicates a key value of the request parameter if MatchKey is `param`, while a key value of the Cookie request header if MatchKey is `cookie`.
        /// </summary>
        [JsonProperty("MatchKeyParam")]
        public string MatchKeyParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MatchKey", this.MatchKey);
            this.SetParamSimple(map, prefix + "LogicOperator", this.LogicOperator);
            this.SetParamArraySimple(map, prefix + "MatchValue.", this.MatchValue);
            this.SetParamSimple(map, prefix + "CaseSensitive", this.CaseSensitive);
            this.SetParamSimple(map, prefix + "MatchKeyParam", this.MatchKeyParam);
        }
    }
}

