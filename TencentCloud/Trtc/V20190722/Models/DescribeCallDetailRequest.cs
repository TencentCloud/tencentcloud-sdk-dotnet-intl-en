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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCallDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of a call: sdkappid_roomgString_createTime. The `roomgString` refers to the room ID, and `createTime` refers to the creation time of a room in the format of UNIX timestamp in seconds, such as 1400353843_218695_1590065777. Its value can be obtained from the `DescribeRoomInformation` API (related document: https://intl.cloud.tencent.com/document/product/647/44050?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("CommId")]
        public string CommId{ get; set; }

        /// <summary>
        /// Query start time in the format of UNIX timestamp, such as 1588031999s, which is a point in time in the last 14 days.
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// Query end time in the format of local UNIX timestamp, such as 1588031999s.
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// User `SDKAppID`, such as 1400188366.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public string SdkAppId{ get; set; }

        /// <summary>
        /// User array to query, which contains up to 6 users. If it is left empty, 6 users will be returned by default.
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// Metric to query. The user list will be returned if it is left empty; all metrics will be returned if its value is `all`.
        /// appCpu: CPU utilization of the application;
        /// sysCpu: CPU utilization of the system;
        /// aBit: upstream/downstream audio bitrate;
        /// aBlock: audio lag duration;
        /// bigvBit: upstream/downstream video bitrate;
        /// bigvCapFps: frame rate for capturing videos;
        /// bigvEncFps: frame rate for sending videos;
        /// bigvDecFps: rendering frame rate;
        /// bigvBlock: video lag duration;
        /// aLoss: upstream/downstream audio packet loss;
        /// bigvLoss: upstream/downstream video packet loss;
        /// bigvWidth: upstream/downstream resolution in width;
        /// bigvHeight: upstream/downstream resolution in height.
        /// </summary>
        [JsonProperty("DataType")]
        public string[] DataType{ get; set; }

        /// <summary>
        /// Page index starting from 0. If either `PageNumber` or `PageSize` is left empty, 6 data entries will be returned by default.
        /// </summary>
        [JsonProperty("PageNumber")]
        public string PageNumber{ get; set; }

        /// <summary>
        /// Number of entries per page. If either `PageNumber` or `PageSize` is left empty, 6 data entries will be returned by default. When either `DataType` or `UserId` is not null, `PageSize` is up to 6. When `DataType` and `UserId` are null, `PageSize` is up to 100.
        /// </summary>
        [JsonProperty("PageSize")]
        public string PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CommId", this.CommId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamArraySimple(map, prefix + "DataType.", this.DataType);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

