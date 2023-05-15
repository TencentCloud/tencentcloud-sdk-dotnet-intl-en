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

    public class DescribeCallDetailInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// The unique ID of a call, whose format is `SdkAppId_CreateTime`, such as `1400xxxxxx_218695_1590065777`. `createTime` is the UNIX timestamp (seconds) when the room was created. Its value can be obtained using the [DescribeRoomInfo](https://intl.cloud.tencent.com/document/product/647/44050?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("CommId")]
        public string CommId{ get; set; }

        /// <summary>
        /// The start time, which is a Unix timestamp (seconds) in local time, such as `1590065777`.
        /// Note: Only data in the last 14 days can be queried.
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// The end time, which is a Unix timestamp (seconds) in local time, such as `1590065877`.
        /// Note: If `DataType` is not null, the end time and start time cannot be more than one hour apart; if `DataType` is null, the end time and start time cannot be more than four hours apart.
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// The application ID, such as `1400xxxxxx`.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// The users to query. If you do not specify this, the data of six users will be returned.
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// The metrics to query. If you do not specify this, only the user list will be returned. If you pass in `all`, all metrics will be returned.
        /// `appCpu`: The CPU utilization of the application.
        /// `sysCpu`: The CPU utilization of the system.
        /// `aBit`: The upstream/downstream audio bitrate (bps).
        /// `aBlock`: The audio stutter duration (ms).
        /// `bigvBit`: The upstream/downstream video bitrate (bps).
        /// `bigvCapFps`: The frame rate for capturing videos.
        /// `bigvEncFps`: The frame rate for sending videos.
        /// `bigvDecFps`: The rendering frame rate.
        /// `bigvBlock`: The video stutter duration (ms).
        /// `aLoss`: The upstream/downstream audio packet loss.
        /// `bigvLoss`: The upstream/downstream video packet loss.
        /// `bigvWidth`: The upstream/downstream resolution (width).
        /// `bigvHeight`: The upstream/downstream resolution (height).
        /// </summary>
        [JsonProperty("DataType")]
        public string[] DataType{ get; set; }

        /// <summary>
        /// The page number. The default is 0.
        /// Note: If `PageNumber` or `PageSize` is not specified, six records will be returned.
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// The number of records per page. The default is `6`.
        /// Value range: 1-100.
        /// Note: If `DataType` is not null, the length of the array `UserIds` and the value of `PageSize` cannot exceed `6`.
        /// If `DataType` is null, the length of the array `UserIds` and the value of `PageSize` cannot exceed `100`.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }


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

