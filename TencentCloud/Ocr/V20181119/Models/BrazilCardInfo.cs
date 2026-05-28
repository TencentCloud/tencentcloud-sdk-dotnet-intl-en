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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BrazilCardInfo : AbstractModel
    {
        
        /// <summary>
        /// RNE document.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RNE")]
        public BrazilRNEInfo RNE{ get; set; }

        /// <summary>
        /// Specifies the document.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RNM")]
        public BrazilRNMInfo RNM{ get; set; }

        /// <summary>
        /// Driver license document.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DriverLicense")]
        public BrazilDriverLicenseInfo DriverLicense{ get; set; }

        /// <summary>
        /// ID card document.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IDCard")]
        public BrazilIDCardInfo IDCard{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RNE.", this.RNE);
            this.SetParamObj(map, prefix + "RNM.", this.RNM);
            this.SetParamObj(map, prefix + "DriverLicense.", this.DriverLicense);
            this.SetParamObj(map, prefix + "IDCard.", this.IDCard);
        }
    }
}

