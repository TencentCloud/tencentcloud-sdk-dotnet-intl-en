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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCaptchaInfoListInternationalRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Pagination parameter - page number</p>
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// <p>Pagination parameters - number of records per page</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>Query parameter - Behavior verification type</p><p>Enumeration values:</p><ul><li>1: Invisible verification</li><li>2: Slide verification</li><li>8: Graphical verification</li><li>9: Voice verification</li></ul>
        /// </summary>
        [JsonProperty("UserSetCapTypeArr")]
        public string[] UserSetCapTypeArr{ get; set; }

        /// <summary>
        /// <p>Query parameter - risk control level</p><p>Enumeration values:</p><ul><li>1: Experience-oriented</li><li>2: Balanced</li><li>3: Security-focused</li></ul>
        /// </summary>
        [JsonProperty("VerifyRankArr")]
        public string[] VerifyRankArr{ get; set; }

        /// <summary>
        /// <p>Query parameter - client multiple selection</p><p>Enumeration values:</p><ul><li>web:</li><li>ios </li><li>android</li></ul>
        /// </summary>
        [JsonProperty("ChannelInfoArr")]
        public string[] ChannelInfoArr{ get; set; }

        /// <summary>
        /// <p>Query parameter -Captcha appid</p>
        /// </summary>
        [JsonProperty("CaptchaAppId")]
        public string CaptchaAppId{ get; set; }

        /// <summary>
        /// <p>Query parameter - Captcha name</p>
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// <p>Sorting parameter</p><p>Input limits: desc: in descending order by creation time; asc: in ascending order by creation time</p>
        /// </summary>
        [JsonProperty("OrderBy")]
        public OrderByInternational OrderBy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArraySimple(map, prefix + "UserSetCapTypeArr.", this.UserSetCapTypeArr);
            this.SetParamArraySimple(map, prefix + "VerifyRankArr.", this.VerifyRankArr);
            this.SetParamArraySimple(map, prefix + "ChannelInfoArr.", this.ChannelInfoArr);
            this.SetParamSimple(map, prefix + "CaptchaAppId", this.CaptchaAppId);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamObj(map, prefix + "OrderBy.", this.OrderBy);
        }
    }
}

