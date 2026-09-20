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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PhilippinesVoteID : AbstractModel
    {
        
        /// <summary>
        /// VIN of Philippines VoteID
        /// </summary>
        [JsonProperty("VIN")]
        public string VIN{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName{ get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [JsonProperty("LastName")]
        public string LastName{ get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// Marital status
        /// </summary>
        [JsonProperty("CivilStatus")]
        public string CivilStatus{ get; set; }

        /// <summary>
        /// Nationality
        /// </summary>
        [JsonProperty("Citizenship")]
        public string Citizenship{ get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// Region.
        /// </summary>
        [JsonProperty("PrecinctNo")]
        public string PrecinctNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VIN", this.VIN);
            this.SetParamSimple(map, prefix + "FirstName", this.FirstName);
            this.SetParamSimple(map, prefix + "LastName", this.LastName);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "CivilStatus", this.CivilStatus);
            this.SetParamSimple(map, prefix + "Citizenship", this.Citizenship);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "PrecinctNo", this.PrecinctNo);
        }
    }
}

