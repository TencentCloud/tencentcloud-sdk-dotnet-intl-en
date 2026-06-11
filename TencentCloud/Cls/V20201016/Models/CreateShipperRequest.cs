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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateShipperRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Log topic Id belonging to the created shipping rule.</p><ul><li>Obtain the log topic Id through <a href="https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1">Get Log Topic List</a>.</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>COS bucket, see the supported <a href="https://www.tencentcloud.com/document/product/436/13312?from_cn_redirect=1">bucket naming conventions</a>.</p><ul><li>Retrieve COS buckets via <a href="https://www.tencentcloud.com/document/product/436/8291?from_cn_redirect=1">GET Service (List Buckets)</a>.</li></ul>
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// <p>New directory prefix delivered by the Shipping Rule.</p><ul><li>Only supports 0-9A-Za-z-_/</li><li>Supports up to 256 characters</li></ul>
        /// </summary>
        [JsonProperty("Prefix")]
        public string Prefix{ get; set; }

        /// <summary>
        /// <p>Shipping rule name. Supports a maximum of 255 characters.</p>
        /// </summary>
        [JsonProperty("ShipperName")]
        public string ShipperName{ get; set; }

        /// <summary>
        /// <p>Shipping time interval in seconds. Default: 300. Range: 300-900.</p>
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// <p>Maximum value of delivered files in MB. Default: 256. Range: 5-256.</p>
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// <p>Filter rules for log shipping. Matched logs are shipped. The relationship between the rules is and. Up to 5 rules are allowed. An empty array indicates all logs are shipped without filtering.</p>
        /// </summary>
        [JsonProperty("FilterRules")]
        public FilterRuleInfo[] FilterRules{ get; set; }

        /// <summary>
        /// <p>Partition rules for log shipping support strftime time format representation</p>
        /// </summary>
        [JsonProperty("Partition")]
        public string Partition{ get; set; }

        /// <summary>
        /// <p>Compression configuration of shipped logs</p>
        /// </summary>
        [JsonProperty("Compress")]
        public CompressInfo Compress{ get; set; }

        /// <summary>
        /// <p>Content format configuration for shipped logs</p>
        /// </summary>
        [JsonProperty("Content")]
        public ContentInfo Content{ get; set; }

        /// <summary>
        /// <p>Delivery file naming configuration. 0: Random number naming, 1: Delivery time naming. Default: 0 (Random number naming).</p>
        /// </summary>
        [JsonProperty("FilenameMode")]
        public ulong? FilenameMode{ get; set; }

        /// <summary>
        /// <p>Starting point of the data shipping range (Unix second-level timestamp). It cannot exceed the starting point of the log topic's lifecycle.<br>If not filled in by the user, it defaults to the time when the user creates the shipping task.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>End time point of the data shipping range (unix second-level timestamp). It cannot be in the future.<br>If not filled in by the user, it defaults to continuous shipping, unlimited.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>The storage type of an object. Default value is STANDARD. For enumeration values, please refer to the <a href="https://www.tencentcloud.com/document/product/436/33417?from_cn_redirect=1">storage type overview</a> document.<br>Reference values include:</p><ul><li>STANDARD: standard storage</li><li>STANDARD_IA: infrequent storage</li><li>ARCHIVE: archive storage</li><li>DEEP_ARCHIVE: deep archive storage</li><li>MAZ_STANDARD: standard storage (multi-AZ)</li><li>MAZ_STANDARD_IA: infrequent storage (multi-AZ)</li><li>INTELLIGENT_TIERING: intelligent tiering storage</li><li>MAZ_INTELLIGENT_TIERING: intelligent tiering storage (multi-AZ)</li></ul>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>Role ARN <a href="https://www.tencentcloud.com/document/product/598/19381?from_cn_redirect=1">Create role</a></p>
        /// </summary>
        [JsonProperty("RoleArn")]
        public string RoleArn{ get; set; }

        /// <summary>
        /// <p>External ID</p>
        /// </summary>
        [JsonProperty("ExternalId")]
        public string ExternalId{ get; set; }

        /// <summary>
        /// <p>Used to generate time variables in the file path shipped to COS.</p><p>Input limit: Support the following time zone list.</p><ul><li>GMT-12:00</li><li>GMT-11:00</li><li>GMT-10:00</li><li>GMT-09:30</li><li>GMT-09:00</li><li>GMT-08:00</li><li>GMT-07:00</li><li>GMT-06:00</li><li>GMT-05:00</li><li>GMT-04:00</li><li>GMT-03:30</li><li>GMT-03:00</li><li>GMT-02:00</li><li>GMT-01:00</li><li>GMT+00:00</li><li>GMT+01:00</li><li>GMT+02:00</li><li>GMT+03:30</li><li>GMT+04:00</li><li>GMT+04:30</li><li>GMT+05:00</li><li>GMT+05:30</li><li>GMT+05:45</li><li>GMT+06:00</li><li>GMT+06:30</li><li>GMT+07:00</li><li>GMT+08:00</li><li>GMT+09:00</li><li>GMT+09:30</li><li>GMT+10:00</li><li>GMT+10:30</li><li>GMT+11:00</li><li>GMT+11:30</li><li>GMT+12:00</li><li>GMT+12:45</li><li>GMT+13:00</li><li>GMT+14:00</li><li>UTC-11:00</li><li>UTC-10:00</li><li>UTC-09:00</li><li>UTC-08:00</li><li>UTC-12:00</li><li>UTC-07:00</li><li>UTC-06:00</li><li>UTC-05:00</li><li>UTC-04:30</li><li>UTC-04:00</li><li>UTC-03:30</li><li>UTC-03:00</li><li>UTC-02:00</li><li>UTC-01:00</li><li>UTC+00:00</li><li>UTC+01:00</li><li>UTC+02:00</li><li>UTC+03:00</li><li>UTC+03:30</li><li>UTC+04:00</li><li>UTC+04:30</li><li>UTC+05:00</li><li>UTC+05:45</li><li>UTC+06:00</li><li>UTC+06:30</li><li>UTC+07:00</li><li>UTC+08:00</li><li>UTC+09:00</li><li>UTC+09:30</li><li>UTC+10:00</li><li>UTC+11:00</li><li>UTC+12:00</li><li>UTC+13:00</li></ul>
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// <p>Pre-filtering process - perform pre-filtering on the original data written to COS</p>
        /// </summary>
        [JsonProperty("DSLFilter")]
        public string DSLFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Prefix", this.Prefix);
            this.SetParamSimple(map, prefix + "ShipperName", this.ShipperName);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamArrayObj(map, prefix + "FilterRules.", this.FilterRules);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamObj(map, prefix + "Compress.", this.Compress);
            this.SetParamObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "FilenameMode", this.FilenameMode);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "ExternalId", this.ExternalId);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "DSLFilter", this.DSLFilter);
        }
    }
}

