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

    public class CosAlarmInfo : AbstractModel
    {
        
        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// Policy name.
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Policy type. 0: Unknown rule category; 1: abnormal behavior; 2: excessive permissions; 3: resource enumeration; 4: anonymous access.
        /// </summary>
        [JsonProperty("PolicyAbnormalType")]
        public long? PolicyAbnormalType{ get; set; }

        /// <summary>
        /// Risk level: 0: Normal, 1: Tip, 2: Low, 3: Middle, 4: High, 5: Critical
        /// </summary>
        [JsonProperty("PolicyRiskLevel")]
        public long? PolicyRiskLevel{ get; set; }

        /// <summary>
        /// Policy information description
        /// </summary>
        [JsonProperty("PolicyDescription")]
        public string PolicyDescription{ get; set; }

        /// <summary>
        /// Bucket name
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// Bucket region.
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// Bucket remarks.
        /// </summary>
        [JsonProperty("BucketMarker")]
        public string BucketMarker{ get; set; }

        /// <summary>
        /// Bucket tag information
        /// </summary>
        [JsonProperty("BucketTagInfo")]
        public string BucketTagInfo{ get; set; }

        /// <summary>
        /// Bucket accessible property
        /// </summary>
        [JsonProperty("BucketAccessWay")]
        public string BucketAccessWay{ get; set; }

        /// <summary>
        /// Account uin
        /// </summary>
        [JsonProperty("AccountUin")]
        public string AccountUin{ get; set; }

        /// <summary>
        /// Account nickname
        /// </summary>
        [JsonProperty("AccountNickName")]
        public string AccountNickName{ get; set; }

        /// <summary>
        /// Identity of the associated account. 1 - Main account. 2 - Sub-account
        /// </summary>
        [JsonProperty("AccountIdentify")]
        public long? AccountIdentify{ get; set; }

        /// <summary>
        /// Nickname of the main account to which the sub-account belongs
        /// </summary>
        [JsonProperty("AccountMainNickName")]
        public string AccountMainNickName{ get; set; }

        /// <summary>
        /// Alarm timestamp in Unix time in milliseconds
        /// </summary>
        [JsonProperty("AlarmTimestamp")]
        public long? AlarmTimestamp{ get; set; }

        /// <summary>
        /// Handling status. 0: unprocessed. 1: tag disposal. 2: marked as ignored.
        /// </summary>
        [JsonProperty("HandleStatus")]
        public long? HandleStatus{ get; set; }

        /// <summary>
        /// Alarm object id
        /// </summary>
        [JsonProperty("AlarmId")]
        public long? AlarmId{ get; set; }

        /// <summary>
        /// Bucket region code value
        /// </summary>
        [JsonProperty("BucketRegionCode")]
        public string BucketRegionCode{ get; set; }

        /// <summary>
        /// Data identification and categorization details
        /// </summary>
        [JsonProperty("CategoryDetails")]
        public CosIdentifyCategoryDetail[] CategoryDetails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyAbnormalType", this.PolicyAbnormalType);
            this.SetParamSimple(map, prefix + "PolicyRiskLevel", this.PolicyRiskLevel);
            this.SetParamSimple(map, prefix + "PolicyDescription", this.PolicyDescription);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "BucketMarker", this.BucketMarker);
            this.SetParamSimple(map, prefix + "BucketTagInfo", this.BucketTagInfo);
            this.SetParamSimple(map, prefix + "BucketAccessWay", this.BucketAccessWay);
            this.SetParamSimple(map, prefix + "AccountUin", this.AccountUin);
            this.SetParamSimple(map, prefix + "AccountNickName", this.AccountNickName);
            this.SetParamSimple(map, prefix + "AccountIdentify", this.AccountIdentify);
            this.SetParamSimple(map, prefix + "AccountMainNickName", this.AccountMainNickName);
            this.SetParamSimple(map, prefix + "AlarmTimestamp", this.AlarmTimestamp);
            this.SetParamSimple(map, prefix + "HandleStatus", this.HandleStatus);
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "BucketRegionCode", this.BucketRegionCode);
            this.SetParamArrayObj(map, prefix + "CategoryDetails.", this.CategoryDetails);
        }
    }
}

