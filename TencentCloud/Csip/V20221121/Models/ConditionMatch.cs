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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConditionMatch : AbstractModel
    {
        
        /// <summary>
        /// <p>Image ID match string (select one of the three, one and only one can be non-empty)</p>
        /// </summary>
        [JsonProperty("ImageIDMatchString")]
        public string ImageIDMatchString{ get; set; }

        /// <summary>
        /// <p>Image name match string (choose one of three, one and only one is non-empty)</p>
        /// </summary>
        [JsonProperty("ImageNameMatchString")]
        public string ImageNameMatchString{ get; set; }

        /// <summary>
        /// <p>Image address match string (Select one of the three. One and only one is non-empty)</p>
        /// </summary>
        [JsonProperty("ImageAddressMatchString")]
        public string ImageAddressMatchString{ get; set; }

        /// <summary>
        /// <p>Match condition. Value: EQUALS-equal to/NOT_EQUALS-not equal to/STARTS_WITH-starting with/NOT_STARTS_WITH-not starting with/ENDS_WITH-ending with/NOT_ENDS_WITH-not ending with/CONTAINS-containing/NOT_CONTAINS-excluding</p>
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageIDMatchString", this.ImageIDMatchString);
            this.SetParamSimple(map, prefix + "ImageNameMatchString", this.ImageNameMatchString);
            this.SetParamSimple(map, prefix + "ImageAddressMatchString", this.ImageAddressMatchString);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
        }
    }
}

