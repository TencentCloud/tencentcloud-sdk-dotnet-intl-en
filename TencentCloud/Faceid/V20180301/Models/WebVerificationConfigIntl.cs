/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class WebVerificationConfigIntl : AbstractModel
    {
        
        /// <summary>
        /// When starting verification, whether to skip the starting verification page. If true, enter the verification process directly. The default is false. This configuration will not take effect if the downgrade policy is triggered.
        /// </summary>
        [JsonProperty("AutoSkipStartPage")]
        public bool? AutoSkipStartPage{ get; set; }

        /// <summary>
        /// When the verification passed, whether to skip the result page and automatically jump to RedirectURL. The default value is false.
        /// Example value: false
        /// </summary>
        [JsonProperty("AutoSkip")]
        public bool? AutoSkip{ get; set; }

        /// <summary>
        /// Detection mode, parameter values are as follows:
        /// 1: OCR+living detection & face comparison;
        /// 2: Living detection & face comparison;
        /// 3: Living detection;
        /// The default value is 2.
        /// Example value: 3
        /// </summary>
        [JsonProperty("CheckMode")]
        public long? CheckMode{ get; set; }

        /// <summary>
        /// The type of lisence used for verification. The following types are supported.
        /// 1.HKIDCard: Hong Kong (China) ID card
        /// 2.MLIDCard: Malaysia ID card
        /// 3.IndonesiaIDCard: Indonesia ID card
        /// 4.PhilippinesVoteID: Philippines VoteID card
        /// 5.PhilippinesDrivingLicense: Philippines driving license
        /// 6.PhilippinesTinID: Philippines TinID card
        /// 7.PhilippinesSSSID: Philippines SSSID card
        /// 8.PhilippinesUMID: Philippines UMID card
        /// 9.InternationalIDPassport: ID cards of Hong Kong, Macao and Taiwan (China), and international passport.
        /// Example: HKIDCard
        /// </summary>
        [JsonProperty("IDCardType")]
        public string IDCardType{ get; set; }

        /// <summary>
        /// Whether to turn off document alarms, the default is false (the alarm detection function is turned on). When enabled, the identity authentication process will be intercepted based on the alarm status of the certificate. If you need to use the document authentication function, please contact us.
        /// </summary>
        [JsonProperty("DisableCheckOcrWarnings")]
        public bool? DisableCheckOcrWarnings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoSkipStartPage", this.AutoSkipStartPage);
            this.SetParamSimple(map, prefix + "AutoSkip", this.AutoSkip);
            this.SetParamSimple(map, prefix + "CheckMode", this.CheckMode);
            this.SetParamSimple(map, prefix + "IDCardType", this.IDCardType);
            this.SetParamSimple(map, prefix + "DisableCheckOcrWarnings", this.DisableCheckOcrWarnings);
        }
    }
}

