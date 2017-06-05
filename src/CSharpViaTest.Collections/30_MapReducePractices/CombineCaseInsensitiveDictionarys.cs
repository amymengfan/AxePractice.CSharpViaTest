﻿using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CSharpViaTest.Collections._30_MapReducePractices
{
    /* 
     * Description
     * ===========
     * 
     * This test will try combine two hashtables. You can use LINQ method for help but
     * you have to complete the test in just one statement.
     * 
     * Requirement
     * ===========
     * 
     * - No `for`, `foreach` or other loop keywords are allowed to use.
     * 
     * Difficulty: Medium
     */
    public class CombineCaseInsensitiveDictionarys
    {
        #region Please modifies the code to pass the test

        static IDictionary<string, ISet<T>> Combine<T>(IDictionary<string, ISet<T>> first, IDictionary<string, ISet<T>> second)
        {
            throw new NotImplementedException();
        }

        #endregion

        [Fact]
        public void should_combine_dictionary_case_insensitively()
        {
            var first = new Dictionary<string, ISet<int>>
            {
                {"Nancy", new HashSet<int> {1, 2}},
                {"nAncy", new HashSet<int> {2, 3, 4}},
                {"Rebecca", new HashSet<int> {1, 2}}
            };

            var second = new Dictionary<string, ISet<int>>
            {
                {"NANCY", new HashSet<int> {1, 8}},
                {"Sofia", new HashSet<int> {2, 9}}
            };

            IDictionary<string, ISet<int>> result = Combine(first, second);
            
            Assert.Equal(3, result.Count);
            Assert.Equal(new [] {1, 2, 3, 4, 8}, result["nancy"].OrderBy(item => item));
            Assert.Equal(new [] {1, 2}, result["rebecca"].OrderBy(item => item));
            Assert.Equal(new [] {2, 9}, result["sofia"].OrderBy(item => item));
        }
    }
}