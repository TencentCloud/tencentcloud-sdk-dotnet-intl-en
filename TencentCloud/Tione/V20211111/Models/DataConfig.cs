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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataConfig : AbstractModel
    {
        
        /// <summary>
        /// Mapping path.
        /// </summary>
        [JsonProperty("MappingPath")]
        public string MappingPath{ get; set; }

        /// <summary>
        /// Storage purpose.
        /// Valid values: BUILTIN_CODE, BUILTIN_DATA, BUILTIN_MODEL, USER_DATA, USER_CODE, USER_MODEL, OUTPUT, and OTHER.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataSourceUsage")]
        public string DataSourceUsage{ get; set; }

        /// <summary>
        /// DATASET, COS, CFS, CFSTurbo, GooseFSx, HDFS, and WEDATA_HDFS
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataSourceType")]
        public string DataSourceType{ get; set; }

        /// <summary>
        /// Data from the data set.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataSetSource")]
        public DataSetConfig DataSetSource{ get; set; }

        /// <summary>
        /// Data from COS.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("COSSource")]
        public CosPathInfo COSSource{ get; set; }

        /// <summary>
        /// Data from CFS.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CFSSource")]
        public CFSConfig CFSSource{ get; set; }

        /// <summary>
        /// Data from HDFS.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HDFSSource")]
        public HDFSConfig HDFSSource{ get; set; }

        /// <summary>
        /// GooseFS data.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GooseFSSource")]
        public GooseFS GooseFSSource{ get; set; }

        /// <summary>
        /// TurboFS data.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CFSTurboSource")]
        public CFSTurbo CFSTurboSource{ get; set; }

        /// <summary>
        /// Information from local disks.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LocalDiskSource")]
        public LocalDisk LocalDiskSource{ get; set; }

        /// <summary>
        /// CBS configuration information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CBSSource")]
        public CBSConfig CBSSource{ get; set; }

        /// <summary>
        /// Host path information.
        /// </summary>
        [JsonProperty("HostPathSource")]
        public HostPath HostPathSource{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PublicDataSource")]
        public PublicDataSourceFS PublicDataSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MappingPath", this.MappingPath);
            this.SetParamSimple(map, prefix + "DataSourceUsage", this.DataSourceUsage);
            this.SetParamSimple(map, prefix + "DataSourceType", this.DataSourceType);
            this.SetParamObj(map, prefix + "DataSetSource.", this.DataSetSource);
            this.SetParamObj(map, prefix + "COSSource.", this.COSSource);
            this.SetParamObj(map, prefix + "CFSSource.", this.CFSSource);
            this.SetParamObj(map, prefix + "HDFSSource.", this.HDFSSource);
            this.SetParamObj(map, prefix + "GooseFSSource.", this.GooseFSSource);
            this.SetParamObj(map, prefix + "CFSTurboSource.", this.CFSTurboSource);
            this.SetParamObj(map, prefix + "LocalDiskSource.", this.LocalDiskSource);
            this.SetParamObj(map, prefix + "CBSSource.", this.CBSSource);
            this.SetParamObj(map, prefix + "HostPathSource.", this.HostPathSource);
            this.SetParamObj(map, prefix + "PublicDataSource.", this.PublicDataSource);
        }
    }
}

