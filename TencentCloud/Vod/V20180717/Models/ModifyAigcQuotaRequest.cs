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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAigcQuotaRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><strong>VOD application ID. For customers who activate on-demand services after December 25, 2023, this field must be filled in with the app ID when accessing resources in on-demand applications, whether in the default application or a newly created application.</strong></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Quota type</p><p>Enumeration values:</p><ul><li>Image: AIGC image task</li><li>Video: AIGC video task</li><li>Text: AIGC text task</li></ul>
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// <p>Number of quotas for the task.</p><p>Unit: images/second/tokens.</p><ul><li>When QuotaType is Image, the unit is images;</li><li>When QuotaType is Video, the unit is seconds;</li><li>When QuotaType is Text, the unit is tokens.</li></ul>
        /// </summary>
        [JsonProperty("QuotaLimit")]
        public ulong? QuotaLimit{ get; set; }

        /// <summary>
        /// <p>Valid only when QuotaType=Text, used to select the ApiToken that requires quota limit</p>
        /// </summary>
        [JsonProperty("ApiToken")]
        public string ApiToken{ get; set; }

        /// <summary>
        /// <p>Quota reset cycle.</p><p>Enumeration values:</p><ul><li>Day: Reset daily.</li><li>Month: Reset on a specified date per month.</li><li>Total: Never reset. The QuotaLimit parameter is the total quota.</li></ul>
        /// </summary>
        [JsonProperty("QuotaPeriod")]
        public string QuotaPeriod{ get; set; }

        /// <summary>
        /// <p>Reset date of the monthly quota. Valid only when QuotaPeriod=Month.</p><p>If the selected date does not exist in the current month, the reset will be postponed to 00:00 on the 1st of the next month.</p>
        /// </summary>
        [JsonProperty("ResetDay")]
        public ulong? ResetDay{ get; set; }

        /// <summary>
        /// <p>Whether to set specified quotas for each model</p><p>Enumeration values: </p><ul><li>ON: Enable</li><li>OFF: Disable</li></ul>
        /// </summary>
        [JsonProperty("ModelQuotaSwitch")]
        public string ModelQuotaSwitch{ get; set; }

        /// <summary>
        /// <p>Quota set for each model, valid only when ModelQuotaSwitch=ON.</p>
        /// </summary>
        [JsonProperty("ModelQuotas")]
        public AigcModelQuota[] ModelQuotas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamSimple(map, prefix + "QuotaLimit", this.QuotaLimit);
            this.SetParamSimple(map, prefix + "ApiToken", this.ApiToken);
            this.SetParamSimple(map, prefix + "QuotaPeriod", this.QuotaPeriod);
            this.SetParamSimple(map, prefix + "ResetDay", this.ResetDay);
            this.SetParamSimple(map, prefix + "ModelQuotaSwitch", this.ModelQuotaSwitch);
            this.SetParamArrayObj(map, prefix + "ModelQuotas.", this.ModelQuotas);
        }
    }
}

