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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRecorderResponse : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable the recorder. Valid values: true (enable), false (disable).
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// Recorder name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Last error message of the recorder, which corresponds to `LastErrorCode`.
        /// </summary>
        [JsonProperty("LastErrorMessage")]
        public string LastErrorMessage{ get; set; }

        /// <summary>
        /// The status of the recorder when it recorded information last time. Valid values: PENDING, OK, FAILED.
        /// </summary>
        [JsonProperty("LastStatus")]
        public string LastStatus{ get; set; }

        /// <summary>
        /// List of the resource types monitored by the recorder
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public RecordResourceType[] ResourceTypes{ get; set; }

        /// <summary>
        /// Time when the recorder was enabled last time
        /// </summary>
        [JsonProperty("LastStartTime")]
        public string LastStartTime{ get; set; }

        /// <summary>
        /// Last error code of the recorder
        /// </summary>
        [JsonProperty("LastErrorCode")]
        public string LastErrorCode{ get; set; }

        /// <summary>
        /// Time when the recorder was disabled last time
        /// </summary>
        [JsonProperty("LastStopTime")]
        public string LastStopTime{ get; set; }

        /// <summary>
        /// Whether to monitor all currently supported resource types. Valid values: true (yes), false (no).
        /// </summary>
        [JsonProperty("AllSupported")]
        public bool? AllSupported{ get; set; }

        /// <summary>
        /// Recorder creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Role name authorized to CFA
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "LastErrorMessage", this.LastErrorMessage);
            this.SetParamSimple(map, prefix + "LastStatus", this.LastStatus);
            this.SetParamArrayObj(map, prefix + "ResourceTypes.", this.ResourceTypes);
            this.SetParamSimple(map, prefix + "LastStartTime", this.LastStartTime);
            this.SetParamSimple(map, prefix + "LastErrorCode", this.LastErrorCode);
            this.SetParamSimple(map, prefix + "LastStopTime", this.LastStopTime);
            this.SetParamSimple(map, prefix + "AllSupported", this.AllSupported);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

